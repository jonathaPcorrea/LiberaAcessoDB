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
    public partial class frmMudaSenha : Form
    {
        public frmMudaSenha()
        {
            InitializeComponent();
        }

        // Variaveis
        int senhaCerta;

        OracleConnection connDB = new OracleConnection("Data Source=govdev;User ID=gaialibdev;Password=gaialibdev");

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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            // Validando Senha Atual
            OracleCommand selectSenhaAtual = new OracleCommand("SELECT 1 FROM usuario WHERE usu_login = :login AND usu_senha = MD5(:senhaAtual)", connDB);
            selectSenhaAtual.Parameters.Add(":login", lbUsuario.Text);
            selectSenhaAtual.Parameters.Add(":senhaAtual", txtSenhaAtual.Text);

            OracleDataReader drSenhaAtual = selectSenhaAtual.ExecuteReader();

            if (drSenhaAtual.Read())
            {
                 senhaCerta = int.Parse(drSenhaAtual["1"].ToString());
            }

            if (senhaCerta == 1)
            {
                OracleCommand updateSenha = new OracleCommand("UPDATE USUARIO SET usu_senha = MD5(:novaSenha), usu_usualt = :usuAlt, usu_datalt = sysdate WHERE usu_login = :login", connDB);
                updateSenha.Parameters.Add(":novaSenha", txtRepeteSenha.Text);
                updateSenha.Parameters.Add(":login", lbUsuario.Text);
                updateSenha.Parameters.Add(":usuAlt", lbUsuario.Text);

                // Atualiza a senha do usuário
                if (txtNovaSenha.Text == txtRepeteSenha.Text)
                {
                    updateSenha.ExecuteNonQuery();
                    MessageBox.Show("Senha atualizada com sucesso!");

                    Close();
                }
                else
                {
                    MessageBox.Show("Senhas não correspondem (Verifique os campos NOVA SENHA e REPETE SENHA).");
                }
            }
            else
            {
                MessageBox.Show("Senha atual está incorreta. Verifique.");
                txtSenhaAtual.Clear();
                txtSenhaAtual.Focus();
            }
        }

        private void frmMudaSenha_Load(object sender, EventArgs e)
        {
            connDB.Open();

            lbUsuario.Visible = true;

            lbUsuario.Text = frmLogin.conectadoComo;
        }
    }
}
