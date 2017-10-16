using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.groupBox1.Controls.Count; i++)
            {
                if (this.groupBox1.Controls[i].GetType().ToString() == "System.Windows.Forms." + this.comboBox3.SelectedItem)
                    this.groupBox1.Controls[i].Visible = true;
            }
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.groupBox1.Controls)
            {
                if (ctrl.GetType().ToString() == "System.Windows.Forms." + this.comboBox3.SelectedItem) this.groupBox1.Controls[this.groupBox1.Controls.IndexOf(ctrl)].Visible = false;
            }
        }

        private void ocultartodo_Click(object sender, EventArgs e)
        {
            foreach (Control x in groupBox1.Controls)
                groupBox1.Controls[groupBox1.Controls.IndexOf(x)].Visible = false;
        }

        private void Mostodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
                groupBox1.Controls[i].Visible = true;
        }
    }
}