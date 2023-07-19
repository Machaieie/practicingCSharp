using Edwin_Work.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edwin_Work
{
    public partial class ClientSide : Form
    {
        public ClientSide()
        {
            InitializeComponent();
        }
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private DateTime time;
        private DateTime tempo;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void btnLevantamento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Levantar());
        }

        private void btnDepositos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Depositar());
        }
    }
}
