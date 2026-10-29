namespace numero_lettere
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.lstRisultati = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(13, 13);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(96, 13);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Inserire una stringa";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(13, 30);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 1;
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(13, 73);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(96, 27);
            this.btn_n1.TabIndex = 2;
            this.btn_n1.Text = "CONTA";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // lstRisultati
            // 
            this.lstRisultati.FormattingEnabled = true;
            this.lstRisultati.Location = new System.Drawing.Point(12, 106);
            this.lstRisultati.Name = "lstRisultati";
            this.lstRisultati.Size = new System.Drawing.Size(120, 95);
            this.lstRisultati.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 227);
            this.Controls.Add(this.lstRisultati);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.ListBox lstRisultati;
    }
}

