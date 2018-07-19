namespace LiberaBanco_v2
{
    partial class frmLogin
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.radioLiberacao = new System.Windows.Forms.RadioButton();
            this.radioSolicitacao = new System.Windows.Forms.RadioButton();
            this.radioMudaSenha = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(25, 36);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(76, 16);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "USUÁRIO";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(42, 64);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(60, 16);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "SENHA";
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrar.Location = new System.Drawing.Point(26, 159);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(128, 59);
            this.btEntrar.TabIndex = 2;
            this.btEntrar.Text = "ENTRAR";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(180, 159);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(128, 59);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(113, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(195, 25);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(113, 61);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(195, 25);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // radioLiberacao
            // 
            this.radioLiberacao.AutoSize = true;
            this.radioLiberacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLiberacao.Location = new System.Drawing.Point(26, 102);
            this.radioLiberacao.Name = "radioLiberacao";
            this.radioLiberacao.Size = new System.Drawing.Size(130, 19);
            this.radioLiberacao.TabIndex = 4;
            this.radioLiberacao.TabStop = true;
            this.radioLiberacao.Text = "Liberação de acesso";
            this.radioLiberacao.UseVisualStyleBackColor = true;
            // 
            // radioSolicitacao
            // 
            this.radioSolicitacao.AutoSize = true;
            this.radioSolicitacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSolicitacao.Location = new System.Drawing.Point(170, 102);
            this.radioSolicitacao.Name = "radioSolicitacao";
            this.radioSolicitacao.Size = new System.Drawing.Size(137, 19);
            this.radioSolicitacao.TabIndex = 5;
            this.radioSolicitacao.TabStop = true;
            this.radioSolicitacao.Text = "Solicitação de acesso";
            this.radioSolicitacao.UseVisualStyleBackColor = true;
            // 
            // radioMudaSenha
            // 
            this.radioMudaSenha.AutoSize = true;
            this.radioMudaSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.radioMudaSenha.ForeColor = System.Drawing.Color.Red;
            this.radioMudaSenha.Location = new System.Drawing.Point(26, 128);
            this.radioMudaSenha.Name = "radioMudaSenha";
            this.radioMudaSenha.Size = new System.Drawing.Size(94, 19);
            this.radioMudaSenha.TabIndex = 6;
            this.radioMudaSenha.TabStop = true;
            this.radioMudaSenha.Text = "Mudar senha";
            this.radioMudaSenha.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(345, 236);
            this.Controls.Add(this.radioMudaSenha);
            this.Controls.Add(this.radioSolicitacao);
            this.Controls.Add(this.radioLiberacao);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberação de acesso a Banco";
            this.Load += new System.EventHandler(this.LiberaBanco_Load);
            this.Enter += new System.EventHandler(this.btEntrar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.RadioButton radioLiberacao;
        private System.Windows.Forms.RadioButton radioSolicitacao;
        private System.Windows.Forms.RadioButton radioMudaSenha;
    }
}

