using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionPressing
{
    public partial class formulairevetement : Form
    {
        public formulairevetement()
        {
            InitializeComponent();
        }
        public void recharger()
        {
            formulairevetement_Load(null, null);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (rdclientexistant.Checked == true)
            {
                txtmle.Enabled = false;
                txtnom.Enabled =false;
                txtprenom.Enabled =false;
                txttel.Enabled = false;
                txtquartier.Enabled = false;

                selectionnerclient formclient = new selectionnerclient();
                formclient.UpdateTextBox += new EventHandler(form2_UpdateTextBox);
                formclient.ShowDialog();
                              
            }
            
            
        }

        private void formulairevetement_Load(object sender, EventArgs e)
        {
            if (Program.mle != "")
            {
                Program.seConnecter();
                MySqlCommand cmd;
                cmd = Program.con.CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM clients WHERE matricule = '"+ Program.mle +"'", Program.con);
                MySqlDataReader dr = cmd.ExecuteReader();

                string mle;
                string nm;
                string prnm;
                int tel ;
                string quartier;

                while (dr.Read())
                {
                    mle = dr.GetString(0);
                    nm = dr.GetString(1);
                    prnm = dr.GetString(2);
                    tel = Int32.Parse(dr.GetString(3));
                    quartier = dr.GetString(4);

                    txtmle.Text = mle;
                    txtnom.Text = nm;
                    txtprenom.Text = prnm;
                    txttel.Text = tel.ToString();
                    txtquartier.Text = quartier;
                }

                
                
            }


            /*
            rdclientexistant.Checked = true;
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM clients", Program.con);
            MySqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                string mlenomprenom = dr.GetString(0) + " " + dr.GetString(1) + " " + dr.GetString(2);
                cbmle.Items.Add(mlenomprenom);
            }*/
        }
        private void btannuller_Click(object sender, EventArgs e)
        {
           
            
        }
        void form2_UpdateTextBox(object sender, EventArgs e)
        {
            UpdateTextBoxEventArgs tbea = e as UpdateTextBoxEventArgs;
            this.txtmle.Text = tbea.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            formulairevetement_Load(null, null);
        }

        private void txtmle_TextChanged(object sender, EventArgs e)
        {
            Program.mle = txtmle.Text;
            if (Program.mle != "")
            {
                Program.seConnecter();
                MySqlCommand cmd;
                cmd = Program.con.CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM clients WHERE matricule = '" + Program.mle + "'", Program.con);
                MySqlDataReader dr = cmd.ExecuteReader();

                string mle;
                string nm;
                string prnm;
                int tel;
                string quartier;

                while (dr.Read())
                {
                    mle = dr.GetString(0);
                    nm = dr.GetString(1);
                    prnm = dr.GetString(2);
                    tel = Int32.Parse(dr.GetString(3));
                    quartier = dr.GetString(4);

                    txtmle.Text = mle;
                    txtnom.Text = nm;
                    txtprenom.Text = prnm;
                    txttel.Text = tel.ToString();
                    txtquartier.Text = quartier;
                }



            }
        }

        private void rdclientnouveau_CheckedChanged(object sender, EventArgs e)
        {
            if (rdclientnouveau.Checked == true)
            {
                txtmle.Text = "";
                txtnom.Text = "";
                txtprenom.Text = "";
                txttel.Text = "";
                txtquartier.Text = "";

                txtmle.Enabled = true;
                txtnom.Enabled = true;
                txtprenom.Enabled = true;
                txttel.Enabled = true;
                txtquartier.Enabled = true;
            }
            
        }
    }
}
