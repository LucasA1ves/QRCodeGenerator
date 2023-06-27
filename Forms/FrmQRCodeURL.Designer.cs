namespace QRCodeGenerator.Forms
{
    partial class FrmQRCodeURL
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
            this.cmbTamanho1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.oUcQRConfig1 = new QRCodeGenerator.ucQRConfig();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTamanho1
            // 
            this.cmbTamanho1.AutoSize = true;
            this.cmbTamanho1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamanho1.Location = new System.Drawing.Point(34, 93);
            this.cmbTamanho1.Name = "cmbTamanho1";
            this.cmbTamanho1.Size = new System.Drawing.Size(60, 25);
            this.cmbTamanho1.TabIndex = 3;
            this.cmbTamanho1.Text = "URL:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.Info;
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(33, 121);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(510, 27);
            this.txtURL.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(593, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 58);
            this.label3.TabIndex = 6;
            this.label3.Text = "QRCode ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImg
            // 
            this.picImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImg.Location = new System.Drawing.Point(593, 93);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(510, 513);
            this.picImg.TabIndex = 7;
            this.picImg.TabStop = false;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(33, 626);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(510, 57);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(969, 626);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(134, 57);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(817, 626);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 57);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // oUcQRConfig1
            // 
            this.oUcQRConfig1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oUcQRConfig1.Location = new System.Drawing.Point(33, 182);
            this.oUcQRConfig1.Name = "oUcQRConfig1";
            this.oUcQRConfig1.Size = new System.Drawing.Size(510, 424);
            this.oUcQRConfig1.TabIndex = 0;
            // 
            // FrmQRCodeURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 695);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.cmbTamanho1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oUcQRConfig1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQRCodeURL";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QRCode URL";
            this.Load += new System.EventHandler(this.FrmQRCodeURL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucQRConfig oUcQRConfig1;
        private System.Windows.Forms.Label cmbTamanho1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}