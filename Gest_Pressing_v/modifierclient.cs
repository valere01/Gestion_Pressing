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
    public partial class modifierclient : Form
    {
        public modifierclient()
        {
            InitializeComponent();
        }

        private void btannullermodif_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
