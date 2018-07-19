namespace LiberaBanco_v2
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioLiberacao = new System.Windows.Forms.RadioButton();
            this.radioSolicitacao = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.cbAmbiente = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtRepeteSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbAmbiente = new System.Windows.Forms.Label();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.lbRepete = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.radioInativo = new System.Windows.Forms.RadioButton();
            this.radioAtivo = new System.Windows.Forms.RadioButton();
            this.footStatus = new System.Windows.Forms.StatusStrip();
            this.footStatusConn = new System.Windows.Forms.ToolStripStatusLabel();
            this.footStatusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewUsuarios = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.footStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(15, 264);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(86, 36);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.Blue;
            this.btEditar.Location = new System.Drawing.Point(154, 264);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(86, 36);
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.Red;
            this.btExcluir.Location = new System.Drawing.Point(293, 264);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(86, 36);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioLiberacao);
            this.groupBox1.Controls.Add(this.radioSolicitacao);
            this.groupBox1.Controls.Add(this.radioAdmin);
            this.groupBox1.Controls.Add(this.cbAmbiente);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtRepeteSenha);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lbAmbiente);
            this.groupBox1.Controls.Add(this.lbPerfil);
            this.groupBox1.Controls.Add(this.lbRepete);
            this.groupBox1.Controls.Add(this.lbSenha);
            this.groupBox1.Controls.Add(this.lbLogin);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 247);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioLiberacao
            // 
            this.radioLiberacao.AutoSize = true;
            this.radioLiberacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLiberacao.Location = new System.Drawing.Point(82, 166);
            this.radioLiberacao.Name = "radioLiberacao";
            this.radioLiberacao.Size = new System.Drawing.Size(76, 19);
            this.radioLiberacao.TabIndex = 5;
            this.radioLiberacao.Text = "Liberação";
            this.radioLiberacao.UseVisualStyleBackColor = true;
            // 
            // radioSolicitacao
            // 
            this.radioSolicitacao.AutoSize = true;
            this.radioSolicitacao.Checked = true;
            this.radioSolicitacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSolicitacao.Location = new System.Drawing.Point(82, 141);
            this.radioSolicitacao.Name = "radioSolicitacao";
            this.radioSolicitacao.Size = new System.Drawing.Size(82, 19);
            this.radioSolicitacao.TabIndex = 4;
            this.radioSolicitacao.TabStop = true;
            this.radioSolicitacao.Text = "Solicitação";
            this.radioSolicitacao.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdmin.Location = new System.Drawing.Point(82, 191);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(64, 19);
            this.radioAdmin.TabIndex = 6;
            this.radioAdmin.Text = "ADMIN";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // cbAmbiente
            // 
            this.cbAmbiente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmbiente.FormattingEnabled = true;
            this.cbAmbiente.Location = new System.Drawing.Point(83, 217);
            this.cbAmbiente.Name = "cbAmbiente";
            this.cbAmbiente.Size = new System.Drawing.Size(173, 23);
            this.cbAmbiente.TabIndex = 7;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(82, 45);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(174, 23);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogin_Validating);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(82, 78);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(174, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtRepeteSenha
            // 
            this.txtRepeteSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeteSenha.Location = new System.Drawing.Point(82, 111);
            this.txtRepeteSenha.Name = "txtRepeteSenha";
            this.txtRepeteSenha.Size = new System.Drawing.Size(174, 23);
            this.txtRepeteSenha.TabIndex = 3;
            this.txtRepeteSenha.UseSystemPasswordChar = true;
            this.txtRepeteSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtRepeteSenha_Validating);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(82, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 23);
            this.txtNome.TabIndex = 0;
            // 
            // lbAmbiente
            // 
            this.lbAmbiente.AutoSize = true;
            this.lbAmbiente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmbiente.Location = new System.Drawing.Point(9, 221);
            this.lbAmbiente.Name = "lbAmbiente";
            this.lbAmbiente.Size = new System.Drawing.Size(68, 15);
            this.lbAmbiente.TabIndex = 5;
            this.lbAmbiente.Text = "AMBIENTE:";
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.Location = new System.Drawing.Point(1, 168);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(76, 15);
            this.lbPerfil.TabIndex = 4;
            this.lbPerfil.Text = "PERMISSÃO:";
            // 
            // lbRepete
            // 
            this.lbRepete.AutoSize = true;
            this.lbRepete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepete.Location = new System.Drawing.Point(28, 115);
            this.lbRepete.Name = "lbRepete";
            this.lbRepete.Size = new System.Drawing.Size(49, 15);
            this.lbRepete.TabIndex = 3;
            this.lbRepete.Text = "REPETE:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(28, 82);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(49, 15);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "SENHA:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(31, 49);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(46, 15);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "LOGIN:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(32, 16);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 15);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "NOME:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.radioInativo);
            this.gbStatus.Controls.Add(this.radioAtivo);
            this.gbStatus.Location = new System.Drawing.Point(263, 141);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(94, 63);
            this.gbStatus.TabIndex = 10;
            this.gbStatus.TabStop = false;
            // 
            // radioInativo
            // 
            this.radioInativo.AutoSize = true;
            this.radioInativo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInativo.ForeColor = System.Drawing.Color.Red;
            this.radioInativo.Location = new System.Drawing.Point(17, 39);
            this.radioInativo.Name = "radioInativo";
            this.radioInativo.Size = new System.Drawing.Size(62, 19);
            this.radioInativo.TabIndex = 1;
            this.radioInativo.Text = "Inativo";
            this.radioInativo.UseVisualStyleBackColor = true;
            // 
            // radioAtivo
            // 
            this.radioAtivo.AutoSize = true;
            this.radioAtivo.Checked = true;
            this.radioAtivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioAtivo.Location = new System.Drawing.Point(17, 11);
            this.radioAtivo.Name = "radioAtivo";
            this.radioAtivo.Size = new System.Drawing.Size(53, 19);
            this.radioAtivo.TabIndex = 0;
            this.radioAtivo.TabStop = true;
            this.radioAtivo.Text = "Ativo";
            this.radioAtivo.UseVisualStyleBackColor = true;
            // 
            // footStatus
            // 
            this.footStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footStatusConn,
            this.footStatusUsuario});
            this.footStatus.Location = new System.Drawing.Point(0, 313);
            this.footStatus.Name = "footStatus";
            this.footStatus.Size = new System.Drawing.Size(895, 22);
            this.footStatus.TabIndex = 5;
            this.footStatus.Text = "statusStrip1";
            // 
            // footStatusConn
            // 
            this.footStatusConn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footStatusConn.Name = "footStatusConn";
            this.footStatusConn.Size = new System.Drawing.Size(103, 17);
            this.footStatusConn.Text = "Conectado como:";
            // 
            // footStatusUsuario
            // 
            this.footStatusUsuario.Name = "footStatusUsuario";
            this.footStatusUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // listViewUsuarios
            // 
            this.listViewUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUsuarios.FullRowSelect = true;
            this.listViewUsuarios.GridLines = true;
            this.listViewUsuarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewUsuarios.Location = new System.Drawing.Point(395, 10);
            this.listViewUsuarios.Name = "listViewUsuarios";
            this.listViewUsuarios.Size = new System.Drawing.Size(485, 240);
            this.listViewUsuarios.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewUsuarios.TabIndex = 11;
            this.listViewUsuarios.UseCompatibleStateImageBehavior = false;
            this.listViewUsuarios.View = System.Windows.Forms.View.Details;
            this.listViewUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewUsuarios_MouseClick);
            this.listViewUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewUsuarios_MouseDoubleClick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 335);
            this.Controls.Add(this.listViewUsuarios);
            this.Controls.Add(this.footStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novos usuários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.usuarios_FormClosed);
            this.Load += new System.EventHandler(this.usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.footStatus.ResumeLayout(false);
            this.footStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip footStatus;
        private System.Windows.Forms.ToolStripStatusLabel footStatusConn;
        private System.Windows.Forms.ToolStripStatusLabel footStatusUsuario;
        private System.Windows.Forms.Label lbAmbiente;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.Label lbRepete;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ComboBox cbAmbiente;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtRepeteSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListView listViewUsuarios;
        private System.Windows.Forms.RadioButton radioLiberacao;
        private System.Windows.Forms.RadioButton radioSolicitacao;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton radioInativo;
        private System.Windows.Forms.RadioButton radioAtivo;
    }
}