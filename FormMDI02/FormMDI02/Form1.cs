﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF1_Click(object sender, EventArgs e)
        {
            Figlia1 f1 = new Figlia1();
            f1.Text = "Figlia 1";
            f1.MdiParent = this;
            f1.Size = new Size(210, 180);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(50, 0);
            f1.Show();

        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Figlia2 f2 = new Figlia2();
            f2.Text = "Figlia 2";
            f2.MdiParent = this;
            f2.Size = new Size(210, 180);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(50, 0);
            f2.Show();
        }

        private void BtnFAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sono state aperte {this.MdiChildren} finestre");
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "Uscire?";
            if (f.ShowDialog()==DialogResult.OK)
            {
                Close();
            }
        }
    }
}
