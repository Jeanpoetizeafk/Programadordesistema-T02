using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantidadeDeEstoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
      

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int quantidade;
            // Verifica se o valor digitado é um número válido
            if (int.TryParse(txtQuantidade.Text, out quantidade))
            {
                if (quantidade < 5)
                {
                    lblResultado.Text = "Alerta: Baixo estoque. Por favor, reabasteça este produto.";
                }
                else
                {
                    lblResultado.Text = "Estoque suficiente.";
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um número válido.");
            }
        }

        
    }
}
    
    
