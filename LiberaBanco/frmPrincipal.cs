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
    public partial class frmPrincipal : Form
    {
        public string strConn = "Data Source=GOVDEV;User ID=gaialibdev;Password=gaialibdev";
        public string strConnSan = "Data Source=SANOFI;User ID=gaialibprd;Password=gaialibprd";
        public string strConnNix = "Data Source=NIX;User ID=gaialibprd;Password=gaialibprd";

        // Conexões com Oracle
        OracleConnection conexaoDB;
        OracleConnection connSanofi;
        OracleConnection connNix;
        // Comando SQL
        OracleCommand ambienteSQL;
        OracleCommand connSQLMaster;
        OracleCommand comandoSQL1;
        OracleCommand comandoSQL2;
        OracleCommand comandoSQL3;
        OracleCommand comandoSQL4;
        OracleCommand updateStatus;
        OracleCommand insertPrdSan;
        OracleCommand insertPrdNix;

        // Variaveis de SQL
        string SQLMaster;
        string strSQL1;
        string strSQL2;
        string strSQL3;
        string strSQL4;
             
        // Variaveis
        int identiUpdate;
        string validaBotoes;
        string dataInicio;
        string dataFim;
        string liberaUsuario;
        int permissoesUsuario;
        string schemaPrd;
        string ambientePrd;

        // Define as solicitações que o usuário verá
        int ambienteDefault;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Encerra aplicação
        private void fechaTudo()
        {
            string msgExit = "Deseja encerrar o programa?";
            string msgCap = "Encerrando aplicação.";

            var resultado = MessageBox.Show(msgExit, msgCap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resultado == DialogResult.No)
            {
                return;
            }
        }
                
        // Valida Radio
        public void validaRadio()
        {
            if (ambienteDefault != 0)
            {
                if (radioTodas.Checked)
                {
                    OracleDataAdapter oraAdapt = new OracleDataAdapter(comandoSQL1);
                    DataTable dtLista = new DataTable();
                    oraAdapt.Fill(dtLista);
                    dataGridPrincipal.DataSource = dtLista;

                }
                else if (radioAguardando.Checked)
                {
                    OracleDataAdapter oraAdapt = new OracleDataAdapter(comandoSQL2);
                    DataTable dtLista = new DataTable();
                    oraAdapt.Fill(dtLista);
                    dataGridPrincipal.DataSource = dtLista;

                }
                else if (radioAprovadas.Checked)
                {
                    OracleDataAdapter oraAdapt = new OracleDataAdapter(comandoSQL3);
                    DataTable dtLista = new DataTable();
                    oraAdapt.Fill(dtLista);
                    dataGridPrincipal.DataSource = dtLista;

                }
                else if (radioReprovadas.Checked)
                {
                    OracleDataAdapter oraAdapt = new OracleDataAdapter(comandoSQL4);
                    DataTable dtLista = new DataTable();
                    oraAdapt.Fill(dtLista);
                    dataGridPrincipal.DataSource = dtLista;

                }
            }
            else if(ambienteDefault == 0)
            {
                if (radioTodas.Checked)
                {
                    OracleDataAdapter oraAdapt = new OracleDataAdapter(connSQLMaster);
                    DataTable dtLista = new DataTable();
                    oraAdapt.Fill(dtLista);
                    dataGridPrincipal.DataSource = dtLista;

                }
                else if (radioAguardando.Checked)
                {
                    OracleDataAdapter oraAdapt = new OracleDataAdapter(comandoSQL2);
                    DataTable dtLista = new DataTable();
                    oraAdapt.Fill(dtLista);
                    dataGridPrincipal.DataSource = dtLista;

                }
                else if (radioAprovadas.Checked)
                {
                    OracleDataAdapter oraAdapt = new OracleDataAdapter(comandoSQL3);
                    DataTable dtLista = new DataTable();
                    oraAdapt.Fill(dtLista);
                    dataGridPrincipal.DataSource = dtLista;

                }
                else if (radioReprovadas.Checked)
                {
                    OracleDataAdapter oraAdapt = new OracleDataAdapter(comandoSQL4);
                    DataTable dtLista = new DataTable();
                    oraAdapt.Fill(dtLista);
                    dataGridPrincipal.DataSource = dtLista;

                }
            }
        }
       
        // Carrega dados do banco
        private void carregaDados()
        {
            string SQLambDefault = "SELECT usu_amb_identi, usu_per_identi FROM USUARIO WHERE USU_LOGIN=:login";

            SQLMaster = "SELECT * FROM V_SOLICITACOES ORDER BY SOLICITAÇÃO DESC";

            strSQL1 = "SELECT * FROM V_SOLICITACOES WHERE AMBIENTE = :AMB_DEFAULT ORDER BY SOLICITAÇÃO DESC";

            strSQL2 = "SELECT * FROM V_SOLICITACOES " +
                              "WHERE STATUS = 'AGUARDANDO' " +
                                "AND AMBIENTE = :AMB_DEFAULT " +
                              "ORDER BY SOLICITAÇÃO DESC";

            strSQL3 = "SELECT * FROM V_SOLICITACOES " +
                              "WHERE STATUS = 'APROVADA' " +
                                "AND AMBIENTE = :AMB_DEFAULT " +
                              "ORDER BY SOLICITAÇÃO DESC";

            strSQL4 = "SELECT * FROM V_SOLICITACOES " +
                              "WHERE STATUS = 'REJEITADA' " +
                                "AND AMBIENTE = :AMB_DEFAULT " +
                              "ORDER BY SOLICITAÇÃO DESC";

            dataGridPrincipal.AllowUserToAddRows = false;

            ambienteSQL = new OracleCommand(SQLambDefault, conexaoDB);
            ambienteSQL.Parameters.AddWithValue(":login", frmLogin.conectadoComo);

            // Seleção fullRow
            this.dataGridPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrincipal.MultiSelect = false;

            // Bloqueia edição dos campos
            dataGridPrincipal.ReadOnly = true;

            try
            {
                OracleDataReader cmd = ambienteSQL.ExecuteReader();

                if (cmd.Read())
                {
                    // Verifica o ambiente e define a ordem
                    ambienteDefault = int.Parse(cmd["usu_amb_identi"].ToString());
                    permissoesUsuario = int.Parse(cmd["usu_per_identi"].ToString());

                    // USUÁRIO GOVERNANÇA
                    if (ambienteDefault == 1)
                    {
                        comandoSQL1 = new OracleCommand(strSQL1, conexaoDB);
                        comandoSQL2 = new OracleCommand(strSQL2, conexaoDB);
                        comandoSQL3 = new OracleCommand(strSQL3, conexaoDB);
                        comandoSQL4 = new OracleCommand(strSQL4, conexaoDB);

                        comandoSQL1.Parameters.AddWithValue(":AMB_DEFAULT", "GOVERNANÇA");
                        comandoSQL2.Parameters.AddWithValue(":AMB_DEFAULT", "GOVERNANÇA");
                        comandoSQL3.Parameters.AddWithValue(":AMB_DEFAULT", "GOVERNANÇA");
                        comandoSQL4.Parameters.AddWithValue(":AMB_DEFAULT", "GOVERNANÇA");
                    }
                    // USUÁRIOS NIX
                    else if (ambienteDefault == 2)
                    {
                        comandoSQL1 = new OracleCommand(strSQL1, conexaoDB);
                        comandoSQL2 = new OracleCommand(strSQL2, conexaoDB);
                        comandoSQL3 = new OracleCommand(strSQL3, conexaoDB);
                        comandoSQL4 = new OracleCommand(strSQL4, conexaoDB);

                        comandoSQL1.Parameters.AddWithValue(":AMB_DEFAULT", "NIX");
                        comandoSQL2.Parameters.AddWithValue(":AMB_DEFAULT", "NIX");
                        comandoSQL3.Parameters.AddWithValue(":AMB_DEFAULT", "NIX");
                        comandoSQL4.Parameters.AddWithValue(":AMB_DEFAULT", "NIX");
                    }
                    // USUARIOS ROOT
                    else if (ambienteDefault == 0)
                    {
                        strSQL2 = "SELECT * FROM V_SOLICITACOES WHERE STATUS = 'AGUARDANDO' ORDER BY SOLICITAÇÃO DESC";
                        strSQL3 = "SELECT * FROM V_SOLICITACOES WHERE STATUS = 'APROVADA' ORDER BY SOLICITAÇÃO DESC";
                        strSQL4 = "SELECT * FROM V_SOLICITACOES WHERE STATUS = 'REJEITADA' ORDER BY SOLICITAÇÃO DESC";

                        connSQLMaster = new OracleCommand(SQLMaster, conexaoDB);
                        comandoSQL2 = new OracleCommand(strSQL2, conexaoDB);
                        comandoSQL3 = new OracleCommand(strSQL3, conexaoDB);
                        comandoSQL4 = new OracleCommand(strSQL4, conexaoDB);

                        // Habilita opções para usuários ROOT
                        topMenuOpSchemas.Enabled = true;
                        topMenuOpUsuarios.Enabled = true;

                        // Se não for usuário root, bloqueia itens da guia opções
                        if (permissoesUsuario != 1)
                        {
                            topMenuOpUsuarios.Enabled = false;
                            topMenuOpSchemas.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioTodas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                validaRadio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioAguardando_CheckedChanged(object sender, EventArgs e)
        {
            //status = "AGUARDANDO";
            try
            {
                validaRadio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioAprovadas_CheckedChanged(object sender, EventArgs e)
        {
            //status = "APROVADA";
            try
            {
                validaRadio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioReprovadas_CheckedChanged(object sender, EventArgs e)
        {
            //status = "REJEITADA";
            try
            {
                validaRadio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Botão aprovar
        private void btAprovar_Click(object sender, EventArgs e)
        {
            // SQLs de update e insert nas bases
            string updateSQL = "UPDATE SOLICITACOES SET SOL_STATUS = 1, SOL_DATALT = sysdate, SOL_USUALT = :conectadoComo WHERE SOL_IDENTI = :identiUpdate";
            string insertSanofiSQL = "INSERT INTO MIDAS.TNU_LIBERA (lib_osuser, lib_schema, lib_datini, lib_datfim) VALUES (:liberarPara, 'gaiasanpltprd', :datIni, :datFim)";
            string insertNixSQL = "INSERT INTO GAIA001PRD.TNU_LIBERA (lib_osuser, lib_schema, lib_datini, lib_datfim) VALUES (:liberarPara, :libSchema, :datIni, :datFim)";

            // Atualiza a tabela GAIALIBDEV com as informações passadas
            updateStatus = new OracleCommand(updateSQL, conexaoDB);
            updateStatus.Parameters.Add(":identiUpdate", identiUpdate);
            updateStatus.Parameters.Add(":conectadoComo", frmLogin.conectadoComo);

            if (ambientePrd == "GOVERNANÇA")
            {
                // Conecta e insere os dados em produção;
                connSanofi.Open();

                insertPrdSan = new OracleCommand(insertSanofiSQL, connSanofi);
                insertPrdSan.Parameters.Add(":liberarPara", liberaUsuario);
                insertPrdSan.Parameters.Add(":datIni", dataInicio);
                insertPrdSan.Parameters.Add(":datFim", dataFim);

                // Executa insert em Produção
                insertPrdSan.ExecuteNonQuery();

                // Fecha conexão do banco
                connSanofi.Close();
            }
            else if (ambientePrd == "NIX")
            {
                // Conecta e insere os dados em produção
                connNix.Open();

                // Insere os parametros
                insertPrdNix = new OracleCommand(insertNixSQL, connNix);
                insertPrdNix.Parameters.Add(":liberarPara", liberaUsuario);
                insertPrdNix.Parameters.Add(":libSchema", schemaPrd);
                insertPrdNix.Parameters.Add(":datIni", dataInicio);
                insertPrdNix.Parameters.Add(":datFim", dataFim);

                // Executa insert em Produção
                insertPrdNix.ExecuteNonQuery();

                // Fecha conexão do banco
                connNix.Close();
            }
            // Executa update em Dev
            updateStatus.ExecuteNonQuery();

            

            dataGridPrincipal.Update();
            dataGridPrincipal.Refresh();

            btAprovar.Enabled = false;
            btReprovar.Enabled = false;

            validaRadio();
        }

        // Botão reprovar
        private void btReprovar_Click(object sender, EventArgs e)
        {
            // Realiza update de aprovação
            string updateSQL = "UPDATE SOLICITACOES SET SOL_STATUS = 2, SOL_DATALT = sysdate, SOL_USUALT = :conectadoComo WHERE SOL_IDENTI = :identiUpdate";

            updateStatus = new OracleCommand(updateSQL, conexaoDB);
            updateStatus.Parameters.Add(":identiUpdate", identiUpdate);
            updateStatus.Parameters.Add(":conectadoComo", frmLogin.conectadoComo);

            updateStatus.ExecuteNonQuery();

            dataGridPrincipal.Update();
            dataGridPrincipal.Refresh();

            validaRadio();
        }

        // Carrega dados no forms
        private void LiberaAcesso_Load(object sender, EventArgs e)
        {
            // Inicia a conexão com o banco
            conexaoDB = new OracleConnection(strConn);
            conexaoDB.Open();

            // Aprensenta o usuário conectado no footMenu
            string usuarioConectado = frmLogin.conectadoComo;
            footStatusConexao.Text = usuarioConectado;

            // Carrega conexões Oracle Produção
            connSanofi = new OracleConnection(strConnSan);
            connNix = new OracleConnection(strConnNix);
            
            carregaDados();

            validaRadio();

            // Desabilita botões
            btAprovar.Enabled = false;
            btReprovar.Enabled = false;

            

        }

        // Seleciona linhas para execução de comandos
        private void dataGridPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seleciona o ID da solicitação.
            identiUpdate = int.Parse(dataGridPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString());

            // Desabilita botões se a solicitação for diferente de "AGUARDANDO"
            validaBotoes = dataGridPrincipal.Rows[e.RowIndex].Cells[9].Value.ToString();

            // Pega usuário
            liberaUsuario = dataGridPrincipal.Rows[e.RowIndex].Cells[2].Value.ToString();

            // Pega Cliente
            schemaPrd = dataGridPrincipal.Rows[e.RowIndex].Cells[5].Value.ToString();

            // Pega Ambiemte
            ambientePrd = dataGridPrincipal.Rows[e.RowIndex].Cells[3].Value.ToString();

            // Data inicio
            dataInicio = dataGridPrincipal.Rows[e.RowIndex].Cells[6].Value.ToString();

            // Data Fim
            dataFim = dataGridPrincipal.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (validaBotoes != "AGUARDANDO")
            {
                btAprovar.Enabled = false;
                btReprovar.Enabled = false;
            }
            else
            {
                btAprovar.Enabled = true;
                btReprovar.Enabled = true;
            }
        }

        // Manutenção de usuários
        private void menuTopUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.ShowDialog();
        }

        // Novas solicitações
        private void menuTopSolicitacao_Click(object sender, EventArgs e)
        {
            frmSolicitacoes frmSolicitacoes = new frmSolicitacoes();
            frmSolicitacoes.ShowDialog();
        }

        // Sair
        private void menuTopSair_Click(object sender, EventArgs e)
        {
            string msgExit = "Deseja encerrar o programa?";
            string msgCap = "Encerrando aplicação.";

            var resultado = MessageBox.Show(msgExit, msgCap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resultado == DialogResult.No)
            {
                return;
            }
        }
        
        private void btRefresh_Click(object sender, EventArgs e)
        {
            carregaDados();
            validaRadio();

            btAprovar.Enabled = false;
            btReprovar.Enabled = false;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msgExit = "Deseja encerrar o programa?";
            string msgCap = "Encerrando aplicação.";

            var resultado = MessageBox.Show(msgExit, msgCap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //Application.Exit();
                e.Cancel = false;
            }
            else if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void topMenuOpSchemas_Click(object sender, EventArgs e)
        {
            frmSchemas fSchemas = new frmSchemas();
            fSchemas.ShowDialog();
        }

    }
}
