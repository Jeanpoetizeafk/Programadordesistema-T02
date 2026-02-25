using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoratrabalhoprofessora
{
    public partial class Form1 : Form
    {
     private Operacao OperacaoSelecionada { get; set; }

       private enum Operacao
        {
            Mais,
            Menos,
            multilicacao,
            Divisao,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {

        }

        private void btnLImpar_Click(object sender, EventArgs e)
        {

        }
    }
}
