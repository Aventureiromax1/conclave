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
    public partial class Form1 : Form
    {
        string[][] papaveis;
        public Form1()
        {
            InitializeComponent();
            papaveis = new string[300][];
        }

        private void BtnGerenciar_Click(object sender, EventArgs e)
        {
            formGerenciar f = new formGerenciar(this, papaveis);
            f.Show();
            this.Hide();
        }
        public void AtribuirPapaveis(string[][] papaveis)
        {
            this.papaveis = papaveis;
        }

        private void BtnVotar_Click(object sender, EventArgs e)
        {
            FrmVotar f = new FrmVotar(this, papaveis);
            f.ShowDialog();
        }

        private void BtnResults_Click(object sender, EventArgs e)
        {
			DialogResult confirmar = MessageBox.Show("Deseja encerrar a votação?", "Encerrar Votação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirmar == DialogResult.No)
				return;

			int totalVotos = 0;
			for (int i = 0; i < papaveis.Length; i++)
			{
				if (papaveis[i] != null && !string.IsNullOrEmpty(papaveis[i][0]))
				{
					int votos = int.Parse(papaveis[i][1]);
					totalVotos += votos;
				}
			}

			int doisTerços = (int)Math.Ceiling(totalVotos * 2.0 / 3.0);
			int eleitoIndex = -1;

			for (int i = 0; i < papaveis.Length; i++)
			{
				if (papaveis[i] != null && !string.IsNullOrEmpty(papaveis[i][0]))
				{
					int votos = int.Parse(papaveis[i][1]);
					if (votos >= doisTerços)
					{
						eleitoIndex = i;
						break;
					}
				}
			}

			if (eleitoIndex == -1)
			{
				MessageBox.Show("Nenhum cardeal atingiu os 2/3 dos votos. Não houve vitorioso.", "Resultado");
				for (int i = 0; i < papaveis.Length; i++)
				{
					if (papaveis[i] != null)
						papaveis[i][1] = "0";
				}
			}
			else
			{
				string nomeEleito = papaveis[eleitoIndex][0];
				DialogResult aceita = MessageBox.Show($"{nomeEleito} foi eleito. Você aceita a eleição canônica à Sumo Pontífice?", "Eleição", MessageBoxButtons.YesNo);

				if (aceita == DialogResult.Yes)
				{
					MessageBox.Show("HABEMUS PAPAM", "Eleição Finalizada");
					for (int i = 0; i < papaveis.Length; i++)
					{
						papaveis[i] = null; // reinicia todo o vetor
					}
				}
				else
				{
					for (int i = 0; i < papaveis.Length; i++)
					{
						if (papaveis[i] != null)
							papaveis[i][1] = "0"; // zera os votos
					}
				}
			}
		}
    }
}
