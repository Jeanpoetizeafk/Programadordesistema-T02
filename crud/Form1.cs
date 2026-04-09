using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// acessando o pacote do mysql
using MySql.Data.MySqlClient;

namespace crud
{
    public partial class frmCadastrodeClientes : Form
    {
        //Conexão com o banco de dados MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; database=db_cadastro";
        public frmCadastrodeClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // validando campos obrigatorios
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCPF.Text.Trim()))

                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.",
                   "validação",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; //impede o prosseguimento se algum campo estiver vazio
                }

                //validação do CPF
                string cpf = txtCPF.Text.Trim();

                if (!isValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF inválido. Certifique-se de que o cpf tenha 11 digitos númericos.",
                        "Validação de CPF",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Impede o prosseguimento se o cpf for inválido
                }
                //Cria a conexao com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                // conexao SQL para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };
                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto,nomesocial, email,cpf)" + "VALUES(@nomecompleto, @nomesocial,@email,@cpf)";

                // adiciona os paramentros com os dados do formulario
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());

                //executa o comando de inserção no banco
                cmd.ExecuteNonQuery();

                //mensagem de sucesso
                MessageBox.Show("Contato inserido com sucesso:",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch
            {

            }
            finally
            {

            }
        }
        private bool isValidCPFLength(string cpf)
        {
            // Remove todos os caracteres não númericos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF tem exatamente 11 dígitos;
            return cpf.Length == 11;

        }
    }
}