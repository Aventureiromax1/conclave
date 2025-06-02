namespace conclave
{
    partial class formGerenciar
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
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnRemove = new System.Windows.Forms.Button();
			this.lblNome = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.dgvPapaveis = new System.Windows.Forms.DataGridView();
			this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPapaveis)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnAdd
			// 
			this.BtnAdd.Location = new System.Drawing.Point(519, 174);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(138, 30);
			this.BtnAdd.TabIndex = 0;
			this.BtnAdd.Text = "Adicionar";
			this.BtnAdd.UseVisualStyleBackColor = true;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnRemove
			// 
			this.BtnRemove.Location = new System.Drawing.Point(553, 210);
			this.BtnRemove.Name = "BtnRemove";
			this.BtnRemove.Size = new System.Drawing.Size(75, 23);
			this.BtnRemove.TabIndex = 1;
			this.BtnRemove.Text = "Excluir";
			this.BtnRemove.UseVisualStyleBackColor = true;
			this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(478, 53);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(519, 53);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 3;
			// 
			// dgvPapaveis
			// 
			this.dgvPapaveis.AllowUserToAddRows = false;
			this.dgvPapaveis.AllowUserToDeleteRows = false;
			this.dgvPapaveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPapaveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome});
			this.dgvPapaveis.Location = new System.Drawing.Point(12, 12);
			this.dgvPapaveis.Name = "dgvPapaveis";
			this.dgvPapaveis.ReadOnly = true;
			this.dgvPapaveis.Size = new System.Drawing.Size(444, 426);
			this.dgvPapaveis.TabIndex = 4;
			// 
			// nome
			// 
			this.nome.HeaderText = "Nome";
			this.nome.Name = "nome";
			this.nome.ReadOnly = true;
			// 
			// formGerenciar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvPapaveis);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.BtnRemove);
			this.Controls.Add(this.BtnAdd);
			this.Name = "formGerenciar";
			this.Text = "formGerenciar";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGerenciar_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvPapaveis)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvPapaveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}