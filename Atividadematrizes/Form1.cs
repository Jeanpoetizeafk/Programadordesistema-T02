using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividadematrizes
{
    public partial class Form1 : Form
    {
        // Matriz 3x3
        private int[,] matriz = new int[3, 3];

        public Form1()
        {
            InitializeComponent();
            // Permitir que o usuário adicione linhas e editar células na tabela
            dgvMatriz.AllowUserToAddRows = true;
            dgvMatriz.ReadOnly = false;
            
        }


        // Evento do botão "Preencher Matriz"
        private void btnPreencher_Click(object sender, EventArgs e)
        {
            try
            {
                // Preenche a matriz com valores aleatórios de 1 a 9
                Random rnd = new Random();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matriz[i, j] = rnd.Next(1, 10);
                    }
                }

                ExibirMatriz();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher a matriz: " + ex.Message);
            }
        }

        // Evento do botão "Somar Elementos"
        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMatriz.Columns.Count == 0)
                {
                    MessageBox.Show("Tabela vazia. Preencha ou gere valores primeiro.");
                    return;
                }

                long soma = 0;
                bool encontrouNumero = false;

                foreach (DataGridViewRow row in dgvMatriz.Rows)
                {
                    if (row.IsNewRow) // pular a linha de adição
                        continue;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                            continue;

                        string texto = cell.Value.ToString().Trim();
                        if (string.IsNullOrEmpty(texto))
                            continue;

                        // Tentar parse como inteiro; se falhar, tentar double e somar como inteiro truncado
                        if (int.TryParse(texto, out int valInt))
                        {
                            soma += valInt;
                            encontrouNumero = true;
                        }
                        else if (double.TryParse(texto, out double valDouble))
                        {
                            soma += (long)valDouble; // arredonda por truncamento
                            encontrouNumero = true;
                        }
                        else
                        {
                            // Ignora valores não numéricos
                        }
                    }
                }

                if (!encontrouNumero)
                {
                    MessageBox.Show("Nenhum número foi encontrado na tabela.");
                    return;
                }

                MessageBox.Show($"Soma dos elementos: {soma}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao somar elementos: " + ex.Message);
            }
        }

        // Método para exibir a matriz no DataGridView
        private void ExibirMatriz()
        {
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();

            // Cria colunas
            for (int j = 0; j < 3; j++)
            {
                dgvMatriz.Columns.Add($"Col{j}", $"Col {j + 1}");
            }

            // Adiciona linhas
            for (int i = 0; i < 3; i++)
            {
                object[] linha = new object[3];
                for (int j = 0; j < 3; j++)
                {
                    linha[j] = matriz[i, j];
                }
                dgvMatriz.Rows.Add(linha);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}