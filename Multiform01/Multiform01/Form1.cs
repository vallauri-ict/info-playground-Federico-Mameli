using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Form 2 senza parametro";
            f2.Show();

            Form2 f2b = new Form2(7);
            f2b.Text = "Form 2 con parametro";
            f2b.Show();
        }

        private void btnForm2b_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Aperta Form Dinamica";
            f2b.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPassaTxt_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(txtPassata);
            f2b.Text = "Form 2 con parametro";
            f2b.Show();
        }

        private void btnFormModale_Click(object sender, EventArgs e)
        {
            FormModale f = new FormModale();
            if(f.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("OK");
                txtEtaFM.Text = f.eta;
                txtNomeFM.Text = f.nome;
            }
            else
                MessageBox.Show("Annulla");
        }
    }
}
