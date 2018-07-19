namespace LiberaBanco_v2
{
    partial class frmSolicitacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitacoes));
            this.lbSolicitante = new System.Windows.Forms.Label();
            this.lbSchema = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.lbFim = new System.Windows.Forms.Label();
            this.lbMotivo = new System.Windows.Forms.Label();
            this.footStatus = new System.Windows.Forms.StatusStrip();
            this.footStatusConn = new System.Windows.Forms.ToolStripStatusLabel();
            this.footStatusConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSolicitar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.cbSchemas = new System.Windows.Forms.ComboBox();
            this.lbUsuarioConn = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.footStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSolicitante
            // 
            this.lbSolicitante.AutoSize = true;
            this.lbSolicitante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolicitante.Location = new System.Drawing.Point(13, 19);
            this.lbSolicitante.Name = "lbSolicitante";
            this.lbSolicitante.Size = new System.Drawing.Size(83, 15);
            this.lbSolicitante.TabIndex = 0;
            this.lbSolicitante.Text = "SOLICITANTE:";
            // 
            // lbSchema
            // 
            this.lbSchema.AutoSize = true;
            this.lbSchema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSchema.Location = new System.Drawing.Point(38, 48);
            this.lbSchema.Name = "lbSchema";
            this.lbSchema.Size = new System.Drawing.Size(58, 15);
            this.lbSchema.TabIndex = 1;
            this.lbSchema.Text = "SCHEMA:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(32, 77);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(64, 15);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "USUÁRIO:";
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.Location = new System.Drawing.Point(49, 106);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(47, 15);
            this.lbInicio.TabIndex = 3;
            this.lbInicio.Text = "INICIO:";
            // 
            // lbFim
            // 
            this.lbFim.AutoSize = true;
            this.lbFim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFim.Location = new System.Drawing.Point(65, 135);
            this.lbFim.Name = "lbFim";
            this.lbFim.Size = new System.Drawing.Size(31, 15);
            this.lbFim.TabIndex = 4;
            this.lbFim.Text = "FIM:";
            // 
            // lbMotivo
            // 
            this.lbMotivo.AutoSize = true;
            this.lbMotivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotivo.Location = new System.Drawing.Point(38, 164);
            this.lbMotivo.Name = "lbMotivo";
            this.lbMotivo.Size = new System.Drawing.Size(58, 15);
            this.lbMotivo.TabIndex = 5;
            this.lbMotivo.Text = "MOTIVO:";
            // 
            // footStatus
            // 
            this.footStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footStatusConn,
            this.footStatusConexao});
            this.footStatus.Location = new System.Drawing.Point(0, 262);
            this.footStatus.Name = "footStatus";
            this.footStatus.Size = new System.Drawing.Size(396, 22);
            this.footStatus.TabIndex = 6;
            this.footStatus.Text = "footMenu";
            // 
            // footStatusConn
            // 
            this.footStatusConn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footStatusConn.Name = "footStatusConn";
            this.footStatusConn.Size = new System.Drawing.Size(103, 17);
            this.footStatusConn.Text = "Conectado como:";
            // 
            // footStatusConexao
            // 
            this.footStatusConexao.Name = "footStatusConexao";
            this.footStatusConexao.Size = new System.Drawing.Size(0, 17);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(257, 204);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(121, 46);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSolicitar
            // 
            this.btSolicitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSolicitar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSolicitar.Image = ((System.Drawing.Image)(resources.GetObject("btSolicitar.Image")));
            this.btSolicitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSolicitar.Location = new System.Drawing.Point(14, 204);
            this.btSolicitar.Name = "btSolicitar";
            this.btSolicitar.Size = new System.Drawing.Size(121, 46);
            this.btSolicitar.TabIndex = 7;
            this.btSolicitar.Text = "SOLICITAR";
            this.btSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSolicitar.UseVisualStyleBackColor = true;
            this.btSolicitar.Click += new System.EventHandler(this.btSolicitar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(102, 73);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 23);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(102, 160);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(275, 23);
            this.txtMotivo.TabIndex = 11;
            // 
            // cbSchemas
            // 
            this.cbSchemas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSchemas.FormattingEnabled = true;
            this.cbSchemas.Location = new System.Drawing.Point(102, 44);
            this.cbSchemas.Name = "cbSchemas";
            this.cbSchemas.Size = new System.Drawing.Size(121, 23);
            this.cbSchemas.TabIndex = 12;
            // 
            // lbUsuarioConn
            // 
            this.lbUsuarioConn.AutoSize = true;
            this.lbUsuarioConn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarioConn.Location = new System.Drawing.Point(102, 19);
            this.lbUsuarioConn.Name = "lbUsuarioConn";
            this.lbUsuarioConn.Size = new System.Drawing.Size(0, 15);
            this.lbUsuarioConn.TabIndex = 13;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(102, 102);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(121, 23);
            this.dtpInicio.TabIndex = 14;
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(102, 131);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(121, 23);
            this.dtpFim.TabIndex = 15;
            // 
            // frmSolicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 284);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lbUsuarioConn);
            this.Controls.Add(this.cbSchemas);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSolicitar);
            this.Controls.Add(this.footStatus);
            this.Controls.Add(this.lbMotivo);
            this.Controls.Add(this.lbFim);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbSchema);
            this.Controls.Add(this.lbSolicitante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSolicitacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar liberação de acesso";
            this.Load += new System.EventHandler(this.Solicitacoes_Load);
            this.footStatus.ResumeLayout(false);
            this.footStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSolicitante;
        private System.Windows.Forms.Label lbSchema;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label lbFim;
        private System.Windows.Forms.Label lbMotivo;
        private System.Windows.Forms.StatusStrip footStatus;
        private System.Windows.Forms.ToolStripStatusLabel footStatusConn;
        private System.Windows.Forms.ToolStripStatusLabel footStatusConexao;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSolicitar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.ComboBox cbSchemas;
        private System.Windows.Forms.Label lbUsuarioConn;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
    }
}