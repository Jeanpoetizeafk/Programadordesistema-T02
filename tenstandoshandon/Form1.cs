using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

namespace Testando_showhide

{

    public partial class frmShowHide : Form

    {

        public frmShowHide()

        {

            InitializeComponent();

            pbLogoTipo.Visible = false;

        }

        private void btnMostrarLogo_Click(object sender, EventArgs e)

        {

            if (pbLogoTipo.Visible)

            {

                pbLogoTipo.Hide();

                btnMostrarLogo.Text = "Mostrar Logo";

            }

            else

            {

                pbLogoTipo.Show();

                btnMostrarLogo.Text = "Esconder Logo";

            }

        }

        private void pbLogoTipo_Click(object sender, EventArgs e)
        {
            frmHome form = new frmHome();
            form.Show();
            this.Hide();
        }
    }
}