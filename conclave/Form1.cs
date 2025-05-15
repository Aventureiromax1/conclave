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
    }
}
