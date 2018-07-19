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
    public partial class frmSolicitacoes : Form
    {
        public frmSolicitacoes()
        {
            InitializeComponent();
        }

        OracleConnection conexaoDB = new OracleConnection("Data Source=govdev;User ID=gaialibdev;Password=gaialibdev");
        OracleCommand selectUsuario;
        OracleCommand selectSchemas;
        OracleCommand novaSolicitacao;

        // Variáveis
        int usuID;
        int schID;
        string schema;

        string usuarioConectado;

        private void carregaDefault()
        {
            // Monta os selects.
            string strSelectUsuario = "SELECT usu_nome, usu_identi FROM USUARIO WHERE usu_login = :usuLogin";
            string strSelectSchemas = "SELECT sch_schema FROM SCHEMAS";

            selectUsuario = new OracleCommand(strSelectUsuario, conexaoDB);

            selectUsuario.Parameters.Add(":usuLogin", usuarioConectado);

            // Execução de Selects
            selectUsuario.ExecuteNonQuery();

            try
            {
                OracleDataReader cmdUsu = selectUsuario.ExecuteReader();

                if (cmdUsu.Read())
                {
                    lbUsuarioConn.Text = cmdUsu["usu_nome"].ToString();

                    // Retorna o ID para a variavel
                    usuID = int.Parse(cmdUsu["usu_identi"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Combo Box de schemas
            selectSchemas = new OracleCommand(strSelectSchemas, conexaoDB);

            OracleDataAdapter oraAdapt = new OracleDataAdapter(selectSchemas);
            DataTable dtLista = new DataTable();
            oraAdapt.Fill(dtLista);

            foreach (DataRow row in dtLista.Rows)
            {
                schema = row["sch_schema"].ToString();
                this.cbSchemas.Items.Add(schema);
            }

        }

        private void Solicitacoes_Load(object sender, EventArgs e)
        {
            // Aprensenta o usuário conectado no footMenu
            usuarioConectado = frmLogin.conectadoComo;
            footStatusConexao.Text = usuarioConectado;

            // Abertura de conexão com o Banco.
            conexaoDB.Open();

            carregaDefault();
        }

        private void btSolicitar_Click(object sender, EventArgs e)
        {
            string strNovaSolicitacao = "INSERT INTO SOLICITACOES VALUES (seq_solicitacoes.nextval, :usuIdenti, :schIdenti, :solUsuario, :solDatini, :solDatfim, :solMotivo, sysdate, 0, null, null)";
            
            // Validando Schema e pegando ID
            OracleCommand validSch = new OracleCommand("SELECT sch_identi FROM SCHEMAS WHERE sch_schema = :schSchema", conexaoDB);
            validSch.Parameters.Add(":schSchema", cbSchemas.Text);
            OracleDataReader drSch = validSch.ExecuteReader();
            if (drSch.Read())
            {
                schID = int.Parse(drSch["sch_identi"].ToString());
            }

            // Valida os campos antes do insert
            if (txtUsuario.Text != "" && txtMotivo.Text != "")
            {
                novaSolicitacao = new OracleCommand(strNovaSolicitacao, conexaoDB);

                novaSolicitacao.Parameters.Add(":usuIdenti", usuID);
                novaSolicitacao.Parameters.Add(":schIdenti", schID);
                novaSolicitacao.Parameters.Add(":solUsuario", txtUsuario.Text);
                novaSolicitacao.Parameters.Add(":solDatini", dtpInicio.Text);
                novaSolicitacao.Parameters.Add(":solDatfim", dtpFim.Text);
                novaSolicitacao.Parameters.Add(":solMotivo", txtMotivo.Text);
                
                novaSolicitacao.ExecuteNonQuery();

                // Finaliza a soliciação e limpa os campos
                MessageBox.Show("Solicitação enviado com sucesso. Aguarde a autorização.");
                txtMotivo.Clear();
                txtUsuario.Clear();

            }
            else
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos. Por favor, verifique.");
                
                if(txtUsuario == null)
                {
                    txtUsuario.BackColor = Color.Red;
                }
                
                if(txtMotivo == null)
                {
                    txtMotivo.BackColor = Color.Red;
                }
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
