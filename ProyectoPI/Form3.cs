using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customizeDesign()
        {
            panelFiltros.Visible = false;
        }

        private void toggleSubmenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }

        private void menuFiltros_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelFiltros);
        }
    }
}
