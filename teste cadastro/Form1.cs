
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace crud

{

    public partial class frmCadastrodeFuncionarios : Form

    {

        //Conexão com o banco de dados MySQL

        MySqlConnection Conexao;

        string data_source = "datasource=localhost; username=root; database=db_funcionarios";

        public frmCadastrodeFuncionarios()

        {

            InitializeComponent();

        }

        private void btnSalvar_Click(object sender, EventArgs e)

        {

            try

            {

                //Validando campos obrigatórios

                if (string.IsNullOrEmpty(txtnome_funcionario.Text.Trim()) ||

                   string.IsNullOrEmpty(txtcargo.Text.Trim()) ||

                   string.IsNullOrEmpty(txttelefone.Text.Trim()) ||

                   string.IsNullOrEmpty(txttipo_acesso.Text.Trim()) ||

                   string.IsNullOrEmpty(txtsenha.Text.Trim()))
                {

                    MessageBox.Show("Todos os campos devem ser preenchidos.",

                                      "Validação",

                                      MessageBoxButtons.OK,

                                      MessageBoxIcon.Warning);

                    return; //Impede o prosseguimento se algum campo estiver vazio

                }

                //Validação do CPF

                string senha = txtsenha.Text.Trim();

                if (!isValidsenhaLength(senha))

                {

                    MessageBox.Show("senha inválida.",

                        "Validação de senha",

                        MessageBoxButtons.OK,

                        MessageBoxIcon.Warning);

                    return; //Impede o prosseguimento se a senha for inválida

                }

                //Cria a conexão com o banco de dados

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco de dados

                MySqlCommand cmd = new MySqlCommand

                {

                    Connection = Conexao

                };

                cmd.Prepare();

                cmd.CommandText = "INSERT INTO funcionarios(id_funcionario, nome_funcionario, cargo, telefone, tipo_acesso, senha) " +

                "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";

                //Adiciona os parâmetros com os dados do formulário

                cmd.Parameters.AddWithValue("@nome_funcionario", txtnome_funcionario.Text.Trim());

                cmd.Parameters.AddWithValue("@cargo", txtcargo.Text.Trim());

                cmd.Parameters.AddWithValue("@telefone", txttelefone.Text.Trim());

                cmd.Parameters.AddWithValue("@tipo_acesso", txttipo_acesso.Text.Trim());

                cmd.Parameters.AddWithValue("@senha", txtsenha.Text.Trim());

                //Executa o comando de inserção no banco

                cmd.ExecuteNonQuery();

                //Mensagem de sucesso

                MessageBox.Show("Contato inserido com sucesso:",

                                "Sucesso",

                                MessageBoxButtons.OK,

                                MessageBoxIcon.Information);

            }

            catch (MySqlException ex)

            {

                //Trata erros relacionados ao MySQL

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,

                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)

            {

                //Trata outros tipos de erro

                MessageBox.Show("Ocorreu: " + ex.Message,

                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            finally

            {

                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro

                if (Conexao != null && Conexao.State == ConnectionState.Open)

                {

                    Conexao.Close();

                }

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


