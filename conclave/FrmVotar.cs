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
    public partial class FrmVotar : Form
    {
        string[][] cardeais;
        Form1 anterior;
        public FrmVotar(Form1 anterior, string[][] cardeais)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.cardeais = cardeais;

            carregar();
        }
        void carregar()
        {
            for (int i = 0; i < funcoes.Length(cardeais); i++)
            {
                lbxCardeais.Items.Add(cardeais[i][0]);
            }
        }
        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (lbxCardeais.SelectedItems.Count != 1)
            {
                MessageBox.Show("selecione um cardeal");
                return;
            }
            string nome = lbxCardeais.SelectedItems[0].ToString();
            int indice = funcoes.buscar(cardeais, nome);
            int votos = int.Parse(cardeais[indice][1]);
            votos++;
            cardeais[indice][1] = votos + "";
            anterior.AtribuirPapaveis(cardeais);
            this.Close();

            MessageBox.Show("Voto computado com sucesso!");
        }
    }
}
