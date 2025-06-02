namespace conclave
{
    partial class Form1
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
			this.BtnGerenciar = new System.Windows.Forms.Button();
			this.BtnVotar = new System.Windows.Forms.Button();
			this.BtnResults = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnGerenciar
			// 
			this.BtnGerenciar.Location = new System.Drawing.Point(12, 12);
			this.BtnGerenciar.Name = "BtnGerenciar";
			this.BtnGerenciar.Size = new System.Drawing.Size(288, 106);
			this.BtnGerenciar.TabIndex = 0;
			this.BtnGerenciar.Text = "Gerenciar Papaveis";
			this.BtnGerenciar.UseVisualStyleBackColor = true;
			this.BtnGerenciar.Click += new System.EventHandler(this.BtnGerenciar_Click);
			// 
			// BtnVotar
			// 
			this.BtnVotar.Location = new System.Drawing.Point(12, 124);
			this.BtnVotar.Name = "BtnVotar";
			this.BtnVotar.Size = new System.Drawing.Size(288, 96);
			this.BtnVotar.TabIndex = 1;
			this.BtnVotar.Text = "Votar";
			this.BtnVotar.UseVisualStyleBackColor = true;
			this.BtnVotar.Click += new System.EventHandler(this.BtnVotar_Click);
			// 
			// BtnResults
			// 
			this.BtnResults.Location = new System.Drawing.Point(12, 226);
			this.BtnResults.Name = "BtnResults";
			this.BtnResults.Size = new System.Drawing.Size(288, 113);
			this.BtnResults.TabIndex = 2;
			this.BtnResults.Text = "Resultados";
			this.BtnResults.UseVisualStyleBackColor = true;
			this.BtnResults.Click += new System.EventHandler(this.BtnResults_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 370);
			this.Controls.Add(this.BtnResults);
			this.Controls.Add(this.BtnVotar);
			this.Controls.Add(this.BtnGerenciar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGerenciar;
        private System.Windows.Forms.Button BtnVotar;
        private System.Windows.Forms.Button BtnResults;
    }
}

