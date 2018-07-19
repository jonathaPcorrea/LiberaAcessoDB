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
    public partial class frmSchemas : Form
    {
        public frmSchemas()
        {
            InitializeComponent();
        }

        // Variaveis
        string amb;
        int ambID;
        int existe;
        int delID;

        // Variaveis da edição
        string edSchema;
        string edAmbiente;
        string edCliente;
        string edBanco;

        // Define se o schema está ativo ou não  --  1 - SIM / 2 - NÃO
        int ativo = 1;

        // Para salvar o usuário quando editado
        bool usouBtEditar = false;

        // Conexão de banco
        OracleConnection connDB = new OracleConnection("Data Source=GOVDEV;User ID=gaialibdev;Password=gaialibdev");

        // Carrega dados do listView
        private void carregaDados()
        {
            listViewSchemas.Clear();

            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            txtBanco.Clear();
            txtCliente.Clear();
            txtSchema.Clear();

            txtSchema.Enabled = true;

            string selectSchemasSQL = "SELECT amb_ambiente, sch_schema, sch_cliente, sch_banco " +
                                        "FROM schemas, ambientes " +
                                       "WHERE sch_amb_identi =  amb_identi " +
                                       "ORDER BY amb_ambiente, sch_schema";

            OracleCommand selectSchemas = new OracleCommand(selectSchemasSQL, connDB);

            OracleDataReader drSch = selectSchemas.ExecuteReader();

            // Preferencias d list view
            listViewSchemas.View = View.Details;
            listViewSchemas.FullRowSelect = true;

            listViewSchemas.Columns.Add("AMBIENTE", 150);
            listViewSchemas.Columns.Add("SCHEMA", 150);
            listViewSchemas.Columns.Add("CLIENTE", 150);
            listViewSchemas.Columns.Add("BANCO", 150);
            //listViewSchemas.Items.Add("");

            if (drSch.HasRows)
            {
                while (drSch.Read())
                {
                    // Monta a linha com as informações
                    string[] row = { drSch["amb_ambiente"].ToString(), drSch["sch_schema"].ToString(), drSch["sch_cliente"].ToString(), drSch["sch_banco"].ToString() };

                    // Adiciona a linha e insere na lista
                    ListViewItem lvi = new ListViewItem(row);

                    listViewSchemas.Items.Add(lvi);
                }
            }

            usouBtEditar = false;
        }

        // Carrega ComboBox
        private void carregaComboBox()
        {
            cbAmbiente.Items.Clear();

            string sqlAmbiente = "SELECT amb_ambiente FROM AMBIENTES WHERE amb_ambiente != 'TODOS'";

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

        // Método de criação de schemas
        private void novoSchema()
        {
            // Valida Radios
            if (radioAtivo.Checked)
            {
                ativo = 1;
            }
            else if (radioInativo.Checked)
            {
                ativo = 2;
            }

            // Validando comboBox
            OracleCommand ambienteID = new OracleCommand("SELECT amb_identi FROM AMBIENTES WHERE amb_ambiente = :ambiente", connDB);

            ambienteID.Parameters.Add(":ambiente", cbAmbiente.Text);

            OracleDataReader drAmb = ambienteID.ExecuteReader();

            if (drAmb.Read())
            {
                ambID = int.Parse(drAmb["amb_identi"].ToString());
            }

            // Insert de dados
            OracleCommand insertSchema = new OracleCommand("INSERT INTO schemas VALUES (seq_schema.nextval, :schNome, :ambIdenti, :schBanco, :schCliente, sysdate, :schAtivo)", connDB);

            // Adiciona os parametros para insert
            insertSchema.Parameters.Add(":schNome", txtSchema.Text);
            insertSchema.Parameters.Add(":ambIdenti", ambID);
            insertSchema.Parameters.Add(":schBanco", txtBanco.Text);
            insertSchema.Parameters.Add(":schCliente", txtCliente.Text);
            insertSchema.Parameters.Add(":schAtivo", ativo);

            insertSchema.ExecuteNonQuery();
        }

        // Carrega os campos para edição
        private void carregaModificao()
        {
            usouBtEditar = true;

            txtSchema.Enabled = false;

            cbAmbiente.Text = edAmbiente;
            txtSchema.Text = edSchema;
            txtCliente.Text = edCliente;
            txtBanco.Text = edBanco;

            OracleCommand oraRadioAtivo = new OracleCommand("SELECT sch_ativo FROM schemas WHERE sch_schema = :schema", connDB);

            oraRadioAtivo.Parameters.Add(":schema", edSchema);

            OracleDataReader dr = oraRadioAtivo.ExecuteReader();

            if(dr.Read())
            {
                int radio = int.Parse(dr["sch_ativo"].ToString());

                if (radio == 1)
                {
                    radioAtivo.Checked = true;
                }
                else if (radio == 2)
                {
                    radioInativo.Checked = true;
                }
            }
        }

        // Método para edição de esquemas
        private void modificaSchema()
        {
            // Valida Radios
            if (radioAtivo.Checked)
            {
                ativo = 1;
            }
            else if (radioInativo.Checked)
            {
                ativo = 2;
            }
            
            // Validando comboBox
            OracleCommand ambienteID = new OracleCommand("SELECT amb_identi FROM AMBIENTES WHERE amb_ambiente = :ambiente", connDB);

            ambienteID.Parameters.Add(":ambiente", cbAmbiente.Text);

            OracleDataReader drAmb = ambienteID.ExecuteReader();

            if (drAmb.Read())
            {
                ambID = int.Parse(drAmb["amb_identi"].ToString());
            }

            // SQL de update
            string updateSchemaSQL = "UPDATE schemas SET sch_amb_identi = :upAmbiente " +
                                                       ",sch_banco = :upBanco " +
                                                       ",sch_cliente = :upCliente " +
                                                       ",sch_ativo = :upAtivo " +
                                                  "WHERE sch_schema = :upSchema";

            OracleCommand updateSchema = new OracleCommand(updateSchemaSQL, connDB);

            // Passagem de parametros
            updateSchema.Parameters.Add(":upAmbiente", ambID);
            updateSchema.Parameters.Add(":upBanco", txtBanco.Text);
            updateSchema.Parameters.Add(":upCliente", txtCliente.Text);
            updateSchema.Parameters.Add(":upAtivo", ativo);
            updateSchema.Parameters.Add(":upSchema", txtSchema.Text);

            updateSchema.ExecuteNonQuery();

        }

        // Valida exclusão
        private void validaExclusao()
        {
            // Select na base
            OracleCommand schemaID = new OracleCommand("SELECT sch_identi FROM schemas WHERE sch_schema = :schema", connDB);
            schemaID.Parameters.Add(":schema", edSchema);

            OracleDataReader dr = schemaID.ExecuteReader();

            if (dr.Read())
            {
                delID = int.Parse(dr["sch_identi"].ToString());
            }

            // Começa a validação de verdade!
            OracleCommand deleteSchema = new OracleCommand("SELECT COUNT(sol_identi) FROM solicitacoes WHERE sol_sch_identi = :delId", connDB);

            deleteSchema.Parameters.Add(":delId", delID);

            OracleDataReader drDel = deleteSchema.ExecuteReader();

            if (drDel.Read())
            {
                int iResultado = int.Parse(drDel["COUNT(sol_identi)"].ToString());

                if (iResultado < 1)
                {
                    string msgTitle = "Exclusão de schema";
                    string msgBody = "Deseja excluir o Schema: " + edSchema + "?";

                    var resultado = MessageBox.Show(msgBody, msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.Yes)
                    {
                        OracleCommand apagaSchema = new OracleCommand("DELETE schemas WHERE sch_schema = :delSchema", connDB);

                        apagaSchema.Parameters.Add(":delSchema", edSchema);

                        apagaSchema.ExecuteNonQuery();

                        // Recarrega a lista de usuários
                        listViewSchemas.Clear();
                        carregaDados();
                        carregaComboBox();

                        usouBtEditar = false;

                    }
                    else if (resultado == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("O Schema não pode ser apagado pois está vinculado a registros. Nesse caso, desative o schema.");

                    // Recarrega a lista de usuários
                    listViewSchemas.Clear();
                    carregaDados();
                    carregaComboBox();

                    usouBtEditar = false;
                }
            }
        }

        private void frmSchemas_Load(object sender, EventArgs e)
        {
            connDB.Open();

            footMenuConnUsuario.Text = frmLogin.conectadoComo;

            carregaDados();
            carregaComboBox();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (usouBtEditar == false)
            {
                // Validando Campos
                if (cbAmbiente.Text == "" || txtSchema.Text == "" || txtCliente.Text == "" || txtBanco.Text == "")
                {
                    MessageBox.Show("Nenhum dos campos pode estar em branco.");
                }
                else
                {
                    // Valida se o schema existe
                    OracleCommand selectSchemaExiste = new OracleCommand("SELECT 1 FROM schemas WHERE sch_schema = :schNome", connDB);

                    selectSchemaExiste.Parameters.Add(":schNome", txtSchema.Text);

                    OracleDataReader dr = selectSchemaExiste.ExecuteReader();

                    if (dr.Read())
                    {
                        existe = int.Parse(dr["1"].ToString());
                    }

                    // Carrega as informações para o banco
                    if (existe < 1)
                    {
                        novoSchema();
                        MessageBox.Show("Schema inserido com sucesso!");

                        txtBanco.Clear();
                        txtCliente.Clear();
                        txtSchema.Clear();

                        carregaDados();
                    }
                    else
                    {
                        MessageBox.Show("O schema já existe.");

                        txtBanco.Clear();
                        txtCliente.Clear();
                        txtSchema.Clear();
                    }
                }
            }
            else if (usouBtEditar == true)
            {
                // Validando Campos
                if (cbAmbiente.Text == "" || txtSchema.Text == "" || txtCliente.Text == "" || txtBanco.Text == "")
                {
                    MessageBox.Show("Nenhum dos campos pode estar em branco.");
                }
                else
                {
                    modificaSchema();

                    MessageBox.Show("Schema alterado com sucesso!");

                    txtBanco.Clear();
                    txtCliente.Clear();
                    txtSchema.Clear();

                    carregaDados();
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            carregaModificao();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            validaExclusao();
        }

        private void listViewSchemas_MouseClick(object sender, MouseEventArgs e)
        {
            edAmbiente = listViewSchemas.SelectedItems[0].SubItems[0].Text;
            edSchema = listViewSchemas.SelectedItems[0].SubItems[1].Text;
            edCliente = listViewSchemas.SelectedItems[0].SubItems[2].Text;
            edBanco = listViewSchemas.SelectedItems[0].SubItems[3].Text;

            btEditar.Enabled = true;
            btExcluir.Enabled = true;
        }

        private void listViewSchemas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaModificao();
        }
    }
}
