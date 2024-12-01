
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_de_ingenieria_economica
{
    public partial class Menu : Form
    {
        private Form currentForm = null;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null) currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           OpenChildForm(new Finanzas.Form2());



        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Finanzas.Rentabilidad());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Finanzas.Estado_de_Resultado());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Finanzas.razones_Liquidez());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Finanzas.Actividad());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Finanzas.Endeudamiento());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Finanzas.lk());
        }
    }
}
