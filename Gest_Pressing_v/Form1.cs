using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPressing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.UpdateTextBox += new EventHandler(form2_UpdateTextBox);
            form2.ShowDialog();
        }

        void form2_UpdateTextBox(object sender, EventArgs e)
        {
            UpdateTextBoxEventArgs tbea = e as UpdateTextBoxEventArgs;
            this.textBox1.Text = tbea.Text;
        }
    }
}
