using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class Frmswitch : Form
    {
        public Frmswitch()
        {
            InitializeComponent();
        }



        private void btnEnviar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var codigo = Convert.ToUInt16(txtCodigoinserido.Text);
                lblDescriacao.Text = GetTipoCombustivel(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }

        }

        private string GetTipoCombustivel(int codigo)
        {
            var result = "";
            switch (codigo)
            {
                case 1:
                    result = "Gasolina";
                    break;
                    
                case 2:
                    result = "Alcool";
                    break;
                    
                case 3:
                    result = "Flex";
                    break;
                    
                case 4:
                    result = "Gas Gnv";
                    break;
                    
                case 5:
                    result = "Disel";
                    break;
                    
                case 6:
                    result = "Invalido";
                    break;

            }

        return result;

        }


      }
    }
