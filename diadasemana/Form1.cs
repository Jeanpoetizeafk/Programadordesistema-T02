using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diadasemana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificardiasemana_Click(object sender, EventArgs e)
        {
            string dia = txtDia.Text.ToLower();
            switch (dia)
            {
                case "segunda":
                case "terça":
                case "quarta":
                case "quinta":
                case "sexta":
                    label1.Text = "É um dia útil.";
                    break;
                case "sábado":
                case "domingo":
                    label1.Text = "É um fim de semana.";
                    break;
                default:
                    MessageBox.Show("Por favor, digite um dia da semana válido.");
                    break;
            }
        }
    }
    
}
