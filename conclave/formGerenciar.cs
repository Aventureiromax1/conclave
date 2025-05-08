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
        }

        private void formGerenciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.AtribuirPapaveis(papaveis);
            anterior.Show();
        }
        int Length(string[][] vetor)
        {
            int q = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != null)
                {
                    q++;
                }
            }
            return q;
        }
        int buscar(string nome)
        {
            int indice;
            for (indice = 0; indice < Length(papaveis) && papaveis[indice][1] != nome; indice++) ;
            if (indice < Length(papaveis))
                return indice;
            return -1;
        }
        void atualizar()
        {
            dgvPapaveis.Rows.Clear();
            for (int i = 0; i < Length(papaveis); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPapaveis);
                for (int j = 0; j < papaveis[i].Length; j++)
                {
                    row.Cells[j].Value = papaveis[i][j];
                }
                dgvPapaveis.Rows.Add(row);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Length(papaveis) == papaveis.Length)
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
            if (buscar(nome) > -1)
            {
                MessageBox.Show("Nome ja cadastrado");
                return;
            }
            int id = 1;
            if (Length(papaveis) > 0)
            {
                id = int.Parse(papaveis[Length(papaveis) - 1][0]) + 1;
            }
            papaveis[Length(papaveis)] = new string[] { id.ToString(), nome };
            MessageBox.Show("Papavel adicionado com sucesso");
            txtNome.Text = "";
            atualizar();
        }
    }
}
