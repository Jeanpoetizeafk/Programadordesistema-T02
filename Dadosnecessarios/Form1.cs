using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dadosnecessarios
{
    public partial class frmFormularioSimples : Form
    {
        public frmFormularioSimples()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroCadastro;

            string nomeUsuario;

            DateTime dataNascimento;

            string cidade;

            bool generoF;

            bool generoM;

            bool generoPD;

            //Validação de campos obrigatórios

            if (string.IsNullOrWhiteSpace(txtNumeroCadastrado.Text))

            {

                MessageBox.Show("Por favor, preencha o número de cadastro.");

                return; //Interrompe a execução do código caso o campo esteja vazio

            }

            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))

            {

                MessageBox.Show("Por favor, preencha o nome completo .");

                return; //Interrompe a execução do código caso o campo esteja vazio

            }

            if (comboBoxCidade.SelectedItem == null)

            {

                MessageBox.Show("Por favor, selecione a cidade .");

                return;

            }

            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked)

            {

                MessageBox.Show("Por favor, selecione o gênero .");

                return;

            }

            //Agora, caso todos os campos estejam preenchidos, a validação prossegue

            numeroCadastro = Convert.ToInt32(txtNumeroCadastrado.Text);

            nomeUsuario = txtNomeCompleto.Text;

            dataNascimento = dateTimePicker1.Value;

            cidade = comboBoxCidade.Text;

            generoF = rbFeminino.Checked;

            generoM = rbMasculino.Checked;

            generoPD = rbNaoBinario.Checked;


            //Formatar a data para exibir apenas a data (sem a hora)
            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");
            //Determina o genero selecionado
            string generoSelecionado = "Não informado"; // caso nenhum genero seja selecionado 

            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else
                generoSelecionado = "Não binario";


                //Exibir as informações em MessageBox

                MessageBox.Show("Número cadastrado: " + numeroCadastro);

            MessageBox.Show("Nome: " + nomeUsuario);

            MessageBox.Show("Data de Nascimento: " + dataFormatada);

            MessageBox.Show("Cidade: " + cidade);

            MessageBox.Show("Genero: " + generoSelecionado);

        }

        private void txtNomeCompleto_Leave(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
        }

        private void txtNumeroCadastrado_Leave(object sender, EventArgs e)
        {
            txtNumeroCadastrado.Clear();
        }
    }
}
