namespace conclave
{
    partial class FrmVotar
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
            this.lblVotar = new System.Windows.Forms.Label();
            this.lbxCardeais = new System.Windows.Forms.ListBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVotar
            // 
            this.lblVotar.AutoSize = true;
            this.lblVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotar.Location = new System.Drawing.Point(86, 9);
            this.lblVotar.Name = "lblVotar";
            this.lblVotar.Size = new System.Drawing.Size(230, 55);
            this.lblVotar.TabIndex = 0;
            this.lblVotar.Text = "Cardeais:";
            // 
            // lbxCardeais
            // 
            this.lbxCardeais.FormattingEnabled = true;
            this.lbxCardeais.Location = new System.Drawing.Point(12, 81);
            this.lbxCardeais.Name = "lbxCardeais";
            this.lbxCardeais.Size = new System.Drawing.Size(372, 238);
            this.lbxCardeais.TabIndex = 1;
            // 
            // btnVotar
            // 
            this.btnVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.Location = new System.Drawing.Point(115, 348);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(150, 50);
            this.btnVotar.TabIndex = 2;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // FrmVotar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.lbxCardeais);
            this.Controls.Add(this.lblVotar);
            this.Name = "FrmVotar";
            this.Text = "FrmVotar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVotar;
        private System.Windows.Forms.ListBox lbxCardeais;
        private System.Windows.Forms.Button btnVotar;
    }
}