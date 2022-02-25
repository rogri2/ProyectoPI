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
    public partial class ShotoPhop : Form
    {
        public ShotoPhop()
        {
            InitializeComponent();
        }

        private void ShotoPhop_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void editImg_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void editVideo_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }
    }
}
