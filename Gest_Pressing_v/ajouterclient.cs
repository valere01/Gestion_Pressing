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
    public partial class ajouterclient : Form
    {
        public ajouterclient()
        {
            InitializeComponent();
        }

        private void btannullerajout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btenregistrerclient_Click(object sender, EventArgs e)
        {
            string nm = txtnom.Text;
            string prnm = txtprenom.Text;
            int tel = Int32.Parse(txttel.Text);
            string qutr = txtquartier.Text;

            Clients client = new Clients();
            client.Mle = Clients.creermatricule();
            client.Nom = nm;
            client.Prenom = prnm;
            client.Tel = tel;
            client.Quartier = qutr;
            client.Date_ajout = Clients.creerdate();
            Clients.Ajouterclient(client);
           
            MessageBox.Show("Enregistrement reussie");
            txtnom.Text="";
            txtprenom.Text="";
            txttel.Text="";
            txtquartier.Text="";
        }
    }
}
