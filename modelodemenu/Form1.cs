using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelodemenu
{
    public partial class Form1 : Form
    {
        bool sidebarExpanded;
        public Form1()
        {
            InitializeComponent();
        }

        private void SidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
                
            { 
                //if sidebar is expand, mininiza
            Sidebar.Width -= 10;
                if(Sidebar.Width -- sidebar.ManimumSize.Width)
                {
                    sidebarExpanded = false;
                    SidebarTime.Stop();
                }
            }
        }
    }
}
