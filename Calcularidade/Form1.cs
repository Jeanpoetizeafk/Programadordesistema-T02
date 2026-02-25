using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcularidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void txtAnoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verificar se a tecla pressionada é enter
            if (e.KeyChar == (char)Keys.Enter)
            {

                // evita o "bip do sistema ao pressionar enter
                e.Handled = true;

                //Declara as variaveis
                int anonascimento, anoatual, idade;


                if (int.TryParse(txtAnoNasc.Text, out anonascimento) && int.TryParse(txtAnoAtual.Text, out anoatual))
                {
                    idade = anoatual - anonascimento;
                    lblIdade.Text = idade.ToString();
                }
                else
                {
                    MessageBox.Show("Digite Numero valido!");
                }
                  
                




               

            }
        }
    }
}
