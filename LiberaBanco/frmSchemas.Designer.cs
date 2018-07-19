namespace LiberaBanco_v2
{
    partial class frmSchemas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchemas));
            this.listViewSchemas = new System.Windows.Forms.ListView();
            this.statusStripConn = new System.Windows.Forms.StatusStrip();
            this.footMenuConn = new System.Windows.Forms.ToolStripStatusLabel();
            this.footMenuConnUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioAtivo = new System.Windows.Forms.RadioButton();
            this.radioInativo = new System.Windows.Forms.RadioButton();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cbAmbiente = new System.Windows.Forms.ComboBox();
            this.txtSchema = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.statusStripConn.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSchemas
            // 
            this.listViewSchemas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSchemas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSchemas.Location = new System.Drawing.Point(290, 10);
            this.listViewSchemas.Name = "listViewSchemas";
            this.listViewSchemas.Size = new System.Drawing.Size(608, 240);
            this.listViewSchemas.TabIndex = 10;
            this.listViewSchemas.UseCompatibleStateImageBehavior = false;
            this.listViewSchemas.View = System.Windows.Forms.View.Details;
            this.listViewSchemas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewSchemas_MouseClick);
            this.listViewSchemas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSchemas_MouseDoubleClick);
            // 
            // statusStripConn
            // 
            this.statusStripConn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footMenuConn,
            this.footMenuConnUsuario});
            this.statusStripConn.Location = new System.Drawing.Point(0, 262);
            this.statusStripConn.Name = "statusStripConn";
            this.statusStripConn.Size = new System.Drawing.Size(909, 22);
            this.statusStripConn.TabIndex = 1;
            this.statusStripConn.Text = "statusStrip1";
            // 
            // footMenuConn
            // 
            this.footMenuConn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footMenuConn.Name = "footMenuConn";
            this.footMenuConn.Size = new System.Drawing.Size(103, 17);
            this.footMenuConn.Text = "Conectado como:";
            // 
            // footMenuConnUsuario
            // 
            this.footMenuConnUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footMenuConnUsuario.Name = "footMenuConnUsuario";
            this.footMenuConnUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "BD SERVER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLIENTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "SCHEMA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "AMBIENTE:";
            // 
            // radioAtivo
            // 
            this.radioAtivo.AutoSize = true;
            this.radioAtivo.Checked = true;
            this.radioAtivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioAtivo.Location = new System.Drawing.Point(105, 175);
            this.radioAtivo.Name = "radioAtivo";
            this.radioAtivo.Size = new System.Drawing.Size(55, 19);
            this.radioAtivo.TabIndex = 5;
            this.radioAtivo.TabStop = true;
            this.radioAtivo.Text = "Ativo";
            this.radioAtivo.UseVisualStyleBackColor = true;
            // 
            // radioInativo
            // 
            this.radioInativo.AutoSize = true;
            this.radioInativo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInativo.ForeColor = System.Drawing.Color.Red;
            this.radioInativo.Location = new System.Drawing.Point(189, 175);
            this.radioInativo.Name = "radioInativo";
            this.radioInativo.Size = new System.Drawing.Size(64, 19);
            this.radioInativo.TabIndex = 6;
            this.radioInativo.TabStop = true;
            this.radioInativo.Text = "Inativo";
            this.radioInativo.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.Red;
            this.btExcluir.Location = new System.Drawing.Point(192, 218);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(71, 32);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.Blue;
            this.btEditar.Location = new System.Drawing.Point(101, 218);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(71, 32);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(10, 218);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(71, 32);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // cbAmbiente
            // 
            this.cbAmbiente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAmbiente.FormattingEnabled = true;
            this.cbAmbiente.Location = new System.Drawing.Point(105, 17);
            this.cbAmbiente.Name = "cbAmbiente";
            this.cbAmbiente.Size = new System.Drawing.Size(121, 23);
            this.cbAmbiente.TabIndex = 0;
            // 
            // txtSchema
            // 
            this.txtSchema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSchema.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchema.Location = new System.Drawing.Point(105, 57);
            this.txtSchema.Name = "txtSchema";
            this.txtSchema.Size = new System.Drawing.Size(154, 23);
            this.txtSchema.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(105, 97);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(154, 23);
            this.txtCliente.TabIndex = 3;
            // 
            // txtBanco
            // 
            this.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBanco.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.Location = new System.Drawing.Point(105, 137);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(154, 23);
            this.txtBanco.TabIndex = 4;
            // 
            // frmSchemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 284);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtSchema);
            this.Controls.Add(this.cbAmbiente);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.radioInativo);
            this.Controls.Add(this.radioAtivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStripConn);
            this.Controls.Add(this.listViewSchemas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSchemas";
            this.Text = "Criação e manutenção de Schemas";
            this.Load += new System.EventHandler(this.frmSchemas_Load);
            this.statusStripConn.ResumeLayout(false);
            this.statusStripConn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSchemas;
        private System.Windows.Forms.StatusStrip statusStripConn;
        private System.Windows.Forms.ToolStripStatusLabel footMenuConn;
        private System.Windows.Forms.ToolStripStatusLabel footMenuConnUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioAtivo;
        private System.Windows.Forms.RadioButton radioInativo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox cbAmbiente;
        private System.Windows.Forms.TextBox txtSchema;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtBanco;

    }
}