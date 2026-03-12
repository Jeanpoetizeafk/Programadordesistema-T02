using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class FrmPictureBox : Form
    {


        private string imagemLocalizada;
        public FrmPictureBox()
        {
            InitializeComponent();
        }

        private void btnVerimagem_Click(object sender, EventArgs e)
        {
        pbCidade.Image = Image.FromFile(@"C:\Users\jean.lgsantos\Downloads\saopaulo.jpg");
        pbCidade.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
            {
            try
            {

                //CAIXA DE DIALOGO PARA ABRIR O ARQUIVO
                OpenFileDialog abrirarquivo = new OpenFileDialog();
                abrirarquivo.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.png)|*.png|all files (*.*)|*.*";
                
                if (abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                 imagemLocalizada = abrirarquivo.FileName;

                    pbanexarImagem.ImageLocation = imagemLocalizada;
                }

            }
            catch (Exception)
            {
            MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
