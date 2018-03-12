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
    public partial class supprimerclient : Form
    {
        public supprimerclient()
        {
            InitializeComponent();
        }

        private void btannullersuppr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
