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
            //set the maximun and minimum size of the sidebar



            if (sidebarExpanded)
                
            { 
                //if sidebar is expand, mininiza
            Sidebar.Width -= 10;
                if(Sidebar.Width <= Sidebar.MinimumSize.Width)
                {
                    sidebarExpanded = false;
                    SidebarTime.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if(Sidebar.Width >= Sidebar.MaximumSize.Width)
                {
                    sidebarExpanded = true;
                    SidebarTime.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest to make it smooth
            SidebarTime.Start();
        }
    }
}
