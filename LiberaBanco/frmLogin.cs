using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace LiberaBanco_v2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OracleConnection conexaoDB = new OracleConnection("Data Source=govdev;User ID=gaialibdev;Password=gaialibdev");

        // Usuário conectado.
        static public string conectadoComo = null;
        static public string telaAcesso = null;

        private void LiberaBanco_Load(object sender, EventArgs e)
        {
            radioLiberacao.Enabled = false;
            radioSolicitacao.Enabled = false;
            conexaoDB.Open();
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            radioLiberacao.Enabled = false;
            radioSolicitacao.Enabled = false;

            organizaUsuario();
        }

        // Ações do botão Entrar
        private void btEntrar_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT usu_login, usu_senha, usu_amb_identi FROM USUARIO WHERE USU_LOGIN=:nome AND USU_SENHA=MD5(:senha)";

            OracleCommand comandoSQL = new OracleCommand(SQL);

            comandoSQL.Connection = conexaoDB;

            // Adiciona os parametros para select na base e validação de usuário.
            comandoSQL.Parameters.AddWithValue(":nome", txtUsuario.Text);
            comandoSQL.Parameters.AddWithValue(":senha", txtSenha.Text);

            // Valida se os campos estão preenchidos e se correspondem com o select
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Usuário não pode estar em branco.");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha não pode ser nula.");
            }
            else
            {
                try
                {
                    OracleDataReader leitura = comandoSQL.ExecuteReader();

                    if (leitura.Read())
                    {
                        conectadoComo = txtUsuario.Text;

                        // Abre o console de liberação de solicitações
                        if (radioLiberacao.Checked)
                        {
                            conexaoDB.Close();

                            telaAcesso = "principal";

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            
                        }
                        // Abre uma nova solicitação
                        else if (radioSolicitacao.Checked)
                        {
                            conexaoDB.Close();

                            telaAcesso = "solicitacao";

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        // Abre mudança de senha
                        else if (radioMudaSenha.Checked)
                        {
                            txtUsuario.Clear();
                            txtSenha.Clear();
                            
                            frmMudaSenha ms = new frmMudaSenha();
                            //ms.Show();
                            ms.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha não conferem. Tente novamente.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        // Ações do botão Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            string msgExit = "Deseja encerrar o programa?";
            string msgCap = "Encerrando aplicação.";

            var resultado = MessageBox.Show(msgExit, msgCap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resultado == DialogResult.No)
            {
                return;
            }

        }

        // Valida se o usuário pode liberar ou apenas solicitar
        private void organizaUsuario()
        {
            string strUserSQL = "SELECT usu_per_identi FROM USUARIO WHERE usu_login = :usuLogin";

            OracleCommand userSQL = new OracleCommand(strUserSQL, conexaoDB);
            userSQL.Parameters.Add(":usuLogin", txtUsuario.Text);

            OracleDataReader drUser = userSQL.ExecuteReader();

            try
            {
                while (drUser.Read())
                {
                    int permissao = int.Parse(drUser["usu_per_identi"].ToString());

                    // Usuário ROOT
                    if (permissao == 1)
                    {
                        radioLiberacao.Enabled = true;
                        radioSolicitacao.Enabled = true;

                        radioLiberacao.PerformClick();
                    }
                    // Usuário Admin
                    else if (permissao == 4)
                    {
                        radioLiberacao.Enabled = true;
                        radioSolicitacao.Enabled = true;

                        radioLiberacao.PerformClick();
                    }
                    // Usuário comum
                    else if (permissao == 2)
                    {
                        radioSolicitacao.Checked = true;
                    }
                    // Usuário Bloqueado
                    else if (permissao == 3)
                    {
                        var invalido = MessageBox.Show("Usuário bloqueado. Verique com seu lider ou gestor.", "Bloqueado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (invalido == DialogResult.OK)
                        {
                            txtUsuario.Clear();
                            txtSenha.Clear();

                            txtUsuario.Focus();
                        }
                        else if (invalido == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Desabilita movimento de tela
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

    }
}
