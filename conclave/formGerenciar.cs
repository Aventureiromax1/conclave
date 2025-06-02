using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conclave
{
    public partial class formGerenciar : Form
    {
        Form1 anterior;
        string[][] papaveis;
        public formGerenciar(Form1 anterior, string[][] papaveis)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.papaveis = papaveis;
            atualizar();
        }

        private void formGerenciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.AtribuirPapaveis(papaveis);
            anterior.Show();
        }
        void atualizar()
        {
            dgvPapaveis.Rows.Clear();
            for (int i = 0; i < funcoes.Length(papaveis); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPapaveis);
                row.Cells[0].Value = papaveis[i][0];
                dgvPapaveis.Rows.Add(row);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (funcoes.Length(papaveis) == papaveis.Length)
            {
                MessageBox.Show("Lista Cheia");
                return;
            }
            string nome = txtNome.Text.Trim();
            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Indique um nome");
                return;
            }
            if (funcoes.buscar(papaveis, nome) > -1)
            {
                MessageBox.Show("Nome ja cadastrado");
                return;
            }
            papaveis[funcoes.Length(papaveis)] = new string[] { nome, "0" };
            MessageBox.Show("Papavel adicionado com sucesso");
            txtNome.Text = "";
            atualizar();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
			if(dgvPapaveis.SelectedCells.Count == 0)

			{
				MessageBox.Show("Selecione um papável para excluir.");
				return;
			}

			string nome = dgvPapaveis.SelectedCells[0].Value.ToString();
			int indice = funcoes.buscar(papaveis, nome);

			DialogResult r = MessageBox.Show($"Tem certeza que deseja excluir {papaveis[indice][0]}?", "Confirmação", MessageBoxButtons.YesNo);
			if (r == DialogResult.Yes)
			{
				for (int i = indice; i < funcoes.Length(papaveis) - 1; i++)
				{
					papaveis[i] = papaveis[i + 1];
				}
				papaveis[funcoes.Length(papaveis) - 1] = null;

				atualizar();
			}
		}
}
