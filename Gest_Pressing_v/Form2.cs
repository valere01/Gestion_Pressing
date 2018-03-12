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
    public partial class Form2 : Form
    {
        public event EventHandler UpdateTextBox;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Closing += new CancelEventHandler(Form2_Closing);
        }

        void Form2_Closing(object sender, CancelEventArgs e)
        {
            this.OnUpdateTextBox();
        }

        private void OnUpdateTextBox()
        {
            if (this.UpdateTextBox != null)
            {
                UpdateTextBoxEventArgs e =
                    new UpdateTextBoxEventArgs(this.textBox1.Text);
                this.UpdateTextBox.Invoke(this, e);
            }
        }
    }
}
