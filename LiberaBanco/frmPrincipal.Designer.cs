namespace LiberaBanco_v2
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dataGridPrincipal = new System.Windows.Forms.DataGridView();
            this.btAprovar = new System.Windows.Forms.Button();
            this.btReprovar = new System.Windows.Forms.Button();
            this.radioTodas = new System.Windows.Forms.RadioButton();
            this.radioAguardando = new System.Windows.Forms.RadioButton();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioReprovadas = new System.Windows.Forms.RadioButton();
            this.radioAprovadas = new System.Windows.Forms.RadioButton();
            this.footMenu = new System.Windows.Forms.StatusStrip();
            this.footStatusConn = new System.Windows.Forms.ToolStripStatusLabel();
            this.footStatusConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.menuTopOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenuOpUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenuOpSolicitacao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.topMenuOpSchemas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuTopSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrincipal)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.footMenu.SuspendLayout();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPrincipal
            // 
            this.dataGridPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPrincipal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrincipal.Location = new System.Drawing.Point(12, 94);
            this.dataGridPrincipal.Name = "dataGridPrincipal";
            this.dataGridPrincipal.Size = new System.Drawing.Size(1098, 470);
            this.dataGridPrincipal.TabIndex = 0;
            this.dataGridPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPrincipal_CellClick);
            // 
            // btAprovar
            // 
            this.btAprovar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAprovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAprovar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAprovar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAprovar.Image = ((System.Drawing.Image)(resources.GetObject("btAprovar.Image")));
            this.btAprovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAprovar.Location = new System.Drawing.Point(856, 29);
            this.btAprovar.Name = "btAprovar";
            this.btAprovar.Size = new System.Drawing.Size(121, 46);
            this.btAprovar.TabIndex = 1;
            this.btAprovar.Text = "APROVAR";
            this.btAprovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAprovar.UseVisualStyleBackColor = true;
            this.btAprovar.Click += new System.EventHandler(this.btAprovar_Click);
            // 
            // btReprovar
            // 
            this.btReprovar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReprovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReprovar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btReprovar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReprovar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReprovar.Image = ((System.Drawing.Image)(resources.GetObject("btReprovar.Image")));
            this.btReprovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReprovar.Location = new System.Drawing.Point(989, 29);
            this.btReprovar.Name = "btReprovar";
            this.btReprovar.Size = new System.Drawing.Size(121, 46);
            this.btReprovar.TabIndex = 2;
            this.btReprovar.Text = "REPROVAR";
            this.btReprovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReprovar.UseVisualStyleBackColor = true;
            this.btReprovar.Click += new System.EventHandler(this.btReprovar_Click);
            // 
            // radioTodas
            // 
            this.radioTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioTodas.AutoSize = true;
            this.radioTodas.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTodas.Location = new System.Drawing.Point(15, 15);
            this.radioTodas.Name = "radioTodas";
            this.radioTodas.Size = new System.Drawing.Size(66, 20);
            this.radioTodas.TabIndex = 3;
            this.radioTodas.Text = "TODAS";
            this.radioTodas.UseVisualStyleBackColor = true;
            this.radioTodas.CheckedChanged += new System.EventHandler(this.radioTodas_CheckedChanged);
            // 
            // radioAguardando
            // 
            this.radioAguardando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAguardando.AutoSize = true;
            this.radioAguardando.Checked = true;
            this.radioAguardando.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAguardando.Location = new System.Drawing.Point(132, 15);
            this.radioAguardando.Name = "radioAguardando";
            this.radioAguardando.Size = new System.Drawing.Size(111, 20);
            this.radioAguardando.TabIndex = 4;
            this.radioAguardando.TabStop = true;
            this.radioAguardando.Text = "AGUARDANDO";
            this.radioAguardando.UseVisualStyleBackColor = true;
            this.radioAguardando.CheckedChanged += new System.EventHandler(this.radioAguardando_CheckedChanged);
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioReprovadas);
            this.groupBoxSelect.Controls.Add(this.radioAprovadas);
            this.groupBoxSelect.Controls.Add(this.radioTodas);
            this.groupBoxSelect.Controls.Add(this.radioAguardando);
            this.groupBoxSelect.Location = new System.Drawing.Point(13, 29);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(476, 46);
            this.groupBoxSelect.TabIndex = 6;
            this.groupBoxSelect.TabStop = false;
            // 
            // radioReprovadas
            // 
            this.radioReprovadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioReprovadas.AutoSize = true;
            this.radioReprovadas.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioReprovadas.Location = new System.Drawing.Point(366, 15);
            this.radioReprovadas.Name = "radioReprovadas";
            this.radioReprovadas.Size = new System.Drawing.Size(104, 20);
            this.radioReprovadas.TabIndex = 6;
            this.radioReprovadas.Text = "REPROVADAS";
            this.radioReprovadas.UseVisualStyleBackColor = true;
            this.radioReprovadas.CheckedChanged += new System.EventHandler(this.radioReprovadas_CheckedChanged);
            // 
            // radioAprovadas
            // 
            this.radioAprovadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAprovadas.AutoSize = true;
            this.radioAprovadas.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAprovadas.Location = new System.Drawing.Point(249, 15);
            this.radioAprovadas.Name = "radioAprovadas";
            this.radioAprovadas.Size = new System.Drawing.Size(97, 20);
            this.radioAprovadas.TabIndex = 5;
            this.radioAprovadas.Text = "APROVADAS";
            this.radioAprovadas.UseVisualStyleBackColor = true;
            this.radioAprovadas.CheckedChanged += new System.EventHandler(this.radioAprovadas_CheckedChanged);
            // 
            // footMenu
            // 
            this.footMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footStatusConn,
            this.footStatusConexao});
            this.footMenu.Location = new System.Drawing.Point(0, 567);
            this.footMenu.Name = "footMenu";
            this.footMenu.Size = new System.Drawing.Size(1122, 22);
            this.footMenu.TabIndex = 7;
            this.footMenu.Text = "footMenu";
            // 
            // footStatusConn
            // 
            this.footStatusConn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footStatusConn.Name = "footStatusConn";
            this.footStatusConn.Size = new System.Drawing.Size(106, 17);
            this.footStatusConn.Text = "Conectado como: ";
            // 
            // footStatusConexao
            // 
            this.footStatusConexao.Name = "footStatusConexao";
            this.footStatusConexao.Size = new System.Drawing.Size(0, 17);
            // 
            // topMenu
            // 
            this.topMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTopOpcoes});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1122, 24);
            this.topMenu.TabIndex = 8;
            this.topMenu.Text = "topMenu";
            // 
            // menuTopOpcoes
            // 
            this.menuTopOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMenuOpUsuarios,
            this.topMenuOpSolicitacao,
            this.toolStripSeparator2,
            this.topMenuOpSchemas,
            this.toolStripSeparator1,
            this.menuTopSair});
            this.menuTopOpcoes.Name = "menuTopOpcoes";
            this.menuTopOpcoes.Size = new System.Drawing.Size(59, 20);
            this.menuTopOpcoes.Text = "Opções";
            // 
            // topMenuOpUsuarios
            // 
            this.topMenuOpUsuarios.Name = "topMenuOpUsuarios";
            this.topMenuOpUsuarios.Size = new System.Drawing.Size(131, 22);
            this.topMenuOpUsuarios.Text = "Usuários";
            this.topMenuOpUsuarios.Click += new System.EventHandler(this.menuTopUsuarios_Click);
            // 
            // topMenuOpSolicitacao
            // 
            this.topMenuOpSolicitacao.Name = "topMenuOpSolicitacao";
            this.topMenuOpSolicitacao.Size = new System.Drawing.Size(131, 22);
            this.topMenuOpSolicitacao.Text = "Solicitação";
            this.topMenuOpSolicitacao.Click += new System.EventHandler(this.menuTopSolicitacao_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // topMenuOpSchemas
            // 
            this.topMenuOpSchemas.Name = "topMenuOpSchemas";
            this.topMenuOpSchemas.Size = new System.Drawing.Size(131, 22);
            this.topMenuOpSchemas.Text = "Schemas";
            this.topMenuOpSchemas.Click += new System.EventHandler(this.topMenuOpSchemas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // menuTopSair
            // 
            this.menuTopSair.Name = "menuTopSair";
            this.menuTopSair.Size = new System.Drawing.Size(131, 22);
            this.menuTopSair.Text = "Sair";
            this.menuTopSair.Click += new System.EventHandler(this.menuTopSair_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRefresh.ForeColor = System.Drawing.Color.White;
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.Location = new System.Drawing.Point(518, 35);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(39, 40);
            this.btRefresh.TabIndex = 7;
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btAprovar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btReprovar;
            this.ClientSize = new System.Drawing.Size(1122, 589);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.footMenu);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.btReprovar);
            this.Controls.Add(this.btAprovar);
            this.Controls.Add(this.dataGridPrincipal);
            this.Controls.Add(this.groupBoxSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenu;
            this.MinimumSize = new System.Drawing.Size(938, 628);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberação de acesso ao Banco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.LiberaAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrincipal)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.footMenu.ResumeLayout(false);
            this.footMenu.PerformLayout();
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPrincipal;
        private System.Windows.Forms.Button btAprovar;
        private System.Windows.Forms.Button btReprovar;
        private System.Windows.Forms.RadioButton radioTodas;
        private System.Windows.Forms.RadioButton radioAguardando;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioAprovadas;
        private System.Windows.Forms.RadioButton radioReprovadas;
        private System.Windows.Forms.StatusStrip footMenu;
        private System.Windows.Forms.ToolStripStatusLabel footStatusConn;
        private System.Windows.Forms.ToolStripStatusLabel footStatusConexao;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem menuTopOpcoes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem topMenuOpUsuarios;
        private System.Windows.Forms.ToolStripMenuItem topMenuOpSolicitacao;
        private System.Windows.Forms.ToolStripMenuItem menuTopSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem topMenuOpSchemas;
        private System.Windows.Forms.Button btRefresh;


    }
}