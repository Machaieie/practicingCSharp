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
    public partial class Management : Form
    {
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private DateTime time;
        private DateTime tempo;
        public Management()
        {
            InitializeComponent();
        }

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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cadastro());
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Atualizar());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Listar());
        }

    

        private void btnClient_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ClientSide());
        }
    }
}
