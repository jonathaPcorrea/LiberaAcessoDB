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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        // Conexão de banco
        OracleConnection connDB = new OracleConnection("Data Source=govdev;User ID=gaialibdev;Password=gaialibdev");

        // Variaveis
        int permissao;
        int ambID;
        string amb;

        // Para salvar o usuário quando editado  --  1 - SIM / 2 - NÃO
        int usouBtEditar = 2;

        string edNome;
        string edLogin;
        int edPermissao;
        int edUsuIdenti;
        string edAmbiente;

        // Carrega os usuários no ListView
        private void carregaUsuarios()
        {
            // Desabilita botões
            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
            btEditar.Enabled = false;

            // Seleciona usuarios
            string strSelectUsuarios = "SELECT usu.usu_nome, usu.usu_login, amb.amb_ambiente " +
                                         "FROM usuario usu, ambientes amb " +
                                        "WHERE usu.usu_amb_identi = amb.amb_identi";

            OracleCommand selectUsuarios = new OracleCommand(strSelectUsuarios, connDB);

            // Recebe dados do banco
            OracleDataReader drUsuario = selectUsuarios.ExecuteReader();

            // Preferencias d list view
            listViewUsuarios.View = View.Details;
            listViewUsuarios.FullRowSelect = true;

            listViewUsuarios.Columns.Add("NOME", 161);
            listViewUsuarios.Columns.Add("LOGIN", 160);
            listViewUsuarios.Columns.Add("AMBIENTE", 160);
            listViewUsuarios.Items.Add("");

            if (drUsuario.HasRows)
            {
                while (drUsuario.Read())
                {
                    // Monta a linha com as informações
                    string[] row = { drUsuario["usu_nome"].ToString(), drUsuario["usu_login"].ToString(), drUsuario["amb_ambiente"].ToString() };

                    // Adiciona a linha e insere na lista
                    ListViewItem lvi = new ListViewItem(row);

                    listViewUsuarios.Items.Add(lvi);
                }
            }
        }

        // Validação de campos preenchidos
        private void validaDados()
        {
            if (txtNome == null)
            {
                MessageBox.Show("Nome não pode estar em branco.");
            }
            else if (txtLogin == null)
            {
                MessageBox.Show("Login não pode estar em branco.");
            }
            else if (cbAmbiente == null)
            {
                MessageBox.Show("Escolha com ambiente do usuário.");
            }
            else if (txtSenha == null)
            {
                MessageBox.Show("Senha não pode estar em branco.");                
            }
            else if (txtNome.Text != "" && txtLogin.Text != "" && txtSenha.Text !="" && txtRepeteSenha.Text != "")
            {
                btSalvar.Enabled = true;
            }

        }

        // Carrega ComboBox
        private void carregaComboBox()
        {
            cbAmbiente.Items.Clear();

            string sqlAmbiente = "SELECT amb_identi, amb_ambiente FROM AMBIENTES";
            
            OracleCommand ambiente = new OracleCommand(sqlAmbiente, connDB);

            OracleDataAdapter oraAdapt = new OracleDataAdapter(ambiente);
            DataTable dtLista = new DataTable();
            oraAdapt.Fill(dtLista);

            foreach (DataRow row in dtLista.Rows)
            {
                amb = row["amb_ambiente"].ToString();

                this.cbAmbiente.Items.Add(amb);
            }
        }

        // Cria novo usuário
        private void novoUsuario()
        {
            // Insere dados no banco
            string insertUser = "INSERT INTO USUARIO (USU_IDENTI, USU_LOGIN, USU_SENHA, USU_DATCRI, USU_PER_IDENTI, USU_AMB_IDENTI, USU_NOME) " +
                                             "VALUES (seq_usuario.nextval, :usuLogin, MD5(:usuSenha), sysdate, :usuPermissao, :usuAmbiente, :usuNome)";

            // Validando comboBox
            OracleCommand ambienteID = new OracleCommand("SELECT amb_identi FROM AMBIENTES WHERE amb_ambiente = :ambiente", connDB);
            OracleCommand insert = new OracleCommand(insertUser, connDB);

            ambienteID.Parameters.Add(":ambiente", cbAmbiente.Text);

            OracleDataReader drAmb = ambienteID.ExecuteReader();

            if (drAmb.Read())
            {
                ambID = int.Parse(drAmb["amb_identi"].ToString());
            }

            // Valida radios de permissões
            if (radioAdmin.Checked)
            {
                permissao = 1;
            }
            else if (radioLiberacao.Checked)
            {
                permissao = 4;
            }
            else if (radioSolicitacao.Checked)
            {
                permissao = 2;
            }

            // Adiciona parametros
            insert.Parameters.Add(":usuLogin", txtLogin.Text);
            insert.Parameters.Add(":usuSenha", txtRepeteSenha.Text);
            insert.Parameters.Add(":usuAmbiente", ambID);
            insert.Parameters.Add(":usuNome", txtNome.Text);
            insert.Parameters.Add(":usuPermissao", permissao);

            // Valida senha
            if (txtSenha.Text == txtRepeteSenha.Text)
            {
                insert.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!");

                // Limpa campos
                limpaCampos();
                carregaComboBox();
            }
            else
            {
                MessageBox.Show("Senhas não correspondem. Verifique.");
                txtSenha.Clear();
                txtRepeteSenha.Clear();
            }

            // Recarrega a lista de usuários
            listViewUsuarios.Clear();
            carregaUsuarios();
        }

        // Carrega usuário para edição
        private void carregaEdicao()
        {
            OracleCommand permissaoSql = new OracleCommand("SELECT usu_identi, usu_per_identi FROM usuario WHERE usu_login = :usuLogin", connDB);
            permissaoSql.Parameters.Add(":usuLogin", edLogin);

            txtNome.Text = edNome;
            txtLogin.Text = edLogin;

            // Seleciona a permissão do cara
            OracleDataReader drPer = permissaoSql.ExecuteReader();
            try
            {
                if (drPer.Read())
                {
                    edPermissao = int.Parse(drPer["usu_per_identi"].ToString());
                    // Pega ID do usuário para Update
                    edUsuIdenti = int.Parse(drPer["usu_identi"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            // Definindo permissões ao editar usuário;
            if (edPermissao == 1)
            {
                radioAdmin.Checked = true;
            }
            else if (edPermissao == 2)
            {
                radioSolicitacao.Checked = true;
            }
            else if (edPermissao == 4)
            {
                radioLiberacao.Checked = true;
            }

            cbAmbiente.Text = edAmbiente;
        }

        // Limpa todos os campos
        private void limpaCampos()
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtRepeteSenha.Clear();
        }

        // Altera usuario
        private void alteraUsuario()
        {
            string updateUserComSenha = "UPDATE usuario SET usu_login = :usuLogin, " + 
                                                           "usu_senha = MD5(:usuSenha), "+
                                                           "usu_per_identi = :permissaoID, " +
                                                           "usu_nome = :usuNome, " + 
                                                           "usu_amb_identi = :ambIdenti, " +
                                                           "usu_usualt = :usuAlt, " +
                                                           "usu_datalt = sysdate " +
                                         "WHERE usu_identi = :usuIdenti";

            string updateUserSemSenha = "UPDATE usuario SET usu_login = :usuLogin, " +
                                                           "usu_per_identi = :permissaoID, " +
                                                           "usu_nome = :usuNome, " +
                                                           "usu_amb_identi = :ambIdenti, " +
                                                           "usu_usualt = :usuAlt, " +
                                                           "usu_datalt = sysdate " +
                                         "WHERE usu_identi = :usuIdenti";

            OracleCommand updateUser = new OracleCommand(updateUserComSenha, connDB);
            OracleCommand updateUserSS = new OracleCommand(updateUserSemSenha, connDB);
            
            // Valida se o usuário está bloqueado
            if (radioAtivo.Checked)
            {
                // Valida radios de permissões
                if (radioAdmin.Checked)
                {
                    permissao = 1;
                }
                else if (radioLiberacao.Checked)
                {
                    permissao = 4;
                }
                else if (radioSolicitacao.Checked)
                {
                    permissao = 2;
                }
            }
            // Usuário bloqueado
            else if (radioInativo.Checked)
            {
                permissao = 3;
            }

            // Validando comboBox
            OracleCommand ambienteID = new OracleCommand("SELECT amb_identi FROM AMBIENTES WHERE amb_ambiente = :ambiente", connDB);

            ambienteID.Parameters.Add(":ambiente", cbAmbiente.Text);

            OracleDataReader drAmb = ambienteID.ExecuteReader();

            if (drAmb.Read())
            {
                ambID = int.Parse(drAmb["amb_identi"].ToString());
            }

            // Caso a senha esteja nula muda o Update
            if (txtSenha.Text == "" && txtRepeteSenha.Text == "")
            {
                // Recebe os parametros
                updateUserSS.Parameters.Add(":usuLogin", txtLogin.Text);
                updateUserSS.Parameters.Add(":permissaoID", permissao);
                updateUserSS.Parameters.Add(":usuNome", txtNome.Text);
                updateUserSS.Parameters.Add(":ambIdenti", ambID);
                updateUserSS.Parameters.Add(":usuAlt", frmLogin.conectadoComo);
                updateUserSS.Parameters.Add(":usuIdenti", edUsuIdenti);

                // Realiza o UPDATE
                updateUserSS.ExecuteNonQuery();

                MessageBox.Show("Usuário atualizado com sucesso!");
                limpaCampos();
            }
            else
            {
                if (txtSenha.Text != txtRepeteSenha.Text)
                {
                    MessageBox.Show("Senhas não conferem. Coloque novamente");
                }
                else if (txtSenha.Text == txtRepeteSenha.Text)
                {
                    // Recebe os parametros
                    updateUser.Parameters.Add(":usuLogin", txtLogin.Text);
                    updateUser.Parameters.Add(":usuIdenti", edUsuIdenti);
                    updateUser.Parameters.Add(":usuSenha", txtRepeteSenha.Text);
                    updateUser.Parameters.Add(":permissaoID", permissao);
                    updateUser.Parameters.Add(":usuNome", txtNome.Text);
                    updateUser.Parameters.Add(":ambIdenti", ambID);
                    updateUser.Parameters.Add(":usuAlt", frmLogin.conectadoComo);

                    // Realiza o UPDATE
                    updateUser.ExecuteNonQuery();

                    MessageBox.Show("Usuário atualizado com sucesso!");
                    limpaCampos();
                }
            }

            // Recarrega a lista de usuários
            listViewUsuarios.Clear();
            carregaUsuarios();
            carregaComboBox();

            usouBtEditar = 2;
        }

        // Deleta usuário da base de dados
        private void deletaUsuario()
        {
            // Deleta usuário
            string deleteUserSQL = "DELETE USUARIO WHERE usu_login = :usuLogin";
            OracleCommand deleteUser = new OracleCommand(deleteUserSQL, connDB);
            deleteUser.Parameters.Add(":usuLogin", edLogin);

            // Verifica se existe algum registro do usuário
            string verificaUserSQL = "SELECT COUNT(sol_identi) FROM solicitacoes WHERE sol_osuser = :usuLogin OR sol_usualt = :usuLogin";
            OracleCommand verificaUser = new OracleCommand(verificaUserSQL, connDB);
            verificaUser.Parameters.Add(":usuLogin", edLogin);

            OracleDataReader drVer = verificaUser.ExecuteReader();

            if (drVer.Read())
            {
                int valida = int.Parse(drVer["COUNT(sol_identi)"].ToString());

                if (valida >= 1 || txtLogin.Text == frmLogin.conectadoComo)
                {
                    MessageBox.Show("O usuário está vinculado a registros ou está conectado, por isso ele não pode ser excluído. Desative-o.");
                }
                else
                {
                    string msgTitle = "Exclusão de usuário";
                    string msgBody = "Deseja excluir o usuário: " + edLogin + "?";

                    var resultado = MessageBox.Show(msgBody, msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.Yes)
                    {
                        deleteUser.ExecuteNonQuery();

                        // Recarrega a lista de usuários
                        listViewUsuarios.Clear();
                        carregaUsuarios();
                        carregaComboBox();

                        usouBtEditar = 2;

                    }
                    else if (resultado == DialogResult.No)
                    {
                        return;
                    }
                }
            }

        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            connDB.Open();

            footStatusUsuario.Text = frmLogin.conectadoComo;

            carregaUsuarios();
            carregaComboBox();

            btEditar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (usouBtEditar == 1)
            {
                alteraUsuario();
                
            }
            else
            {
                validaDados();
                novoUsuario();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            usouBtEditar = 1;
            carregaEdicao();
            btSalvar.Enabled = true;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            deletaUsuario();
        }

        // Valida se o login já existe
        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            string ValidaLogin = "SELECT COUNT(usu_login) FROM USUARIO WHERE usu_login = :usuLogin";

            OracleCommand login = new OracleCommand(ValidaLogin, connDB);
            login.Parameters.Add(":usuLogin", txtLogin.Text);

            OracleDataReader drUser = login.ExecuteReader();

            try
            {
                while (drUser.Read())
                {
                    int existe = int.Parse(drUser[0].ToString());

                    // Usuário já existe na base
                    if (existe == 1)
                    {
                        MessageBox.Show("Esse Login já existe na base de dados.");
                    }
                    // Usuário Admin
                    else if (existe == 0)
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void listViewUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            edNome = listViewUsuarios.SelectedItems[0].SubItems[0].Text;
            edLogin = listViewUsuarios.SelectedItems[0].SubItems[1].Text;
            edAmbiente = listViewUsuarios.SelectedItems[0].SubItems[2].Text;

            btEditar.Enabled = true;
            btExcluir.Enabled = true;
        }

        private void txtRepeteSenha_Validating(object sender, CancelEventArgs e)
        {
            validaDados();
        }

        private void listViewUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            usouBtEditar = 1;
            carregaEdicao();
            btSalvar.Enabled = true;
        }

    }
}
