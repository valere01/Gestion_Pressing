using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestionPressing
{
    class Factures
    {
        public static DataTable tablesfactures = new DataTable();

        private string code_f;
        private int montant;
        private string mention;
        private string date_creation;

        public Factures()
        {
            this.code_f = "";
            this.montant = 0;
            this.mention = "";
            this.date_creation = "";
        }

        public Factures(string code_f, int montant, string mention, string date_creation)
        {
            this.code_f = code_f;
            this.montant = montant;
            this.mention = mention;
            this.date_creation = date_creation;
        }

        public string Code_f
        {
            get { return this.code_f; }
            set { this.code_f = value; }
        }

        public int Montant
        {
            get { return this.montant; }
            set { this.montant = value; }
        }

        public string Mention
        {
            get { return this.mention; }
            set { this.mention = value; }
        }

        public string Date_mention
        {
            get { return this.date_creation; }
            set { this.date_creation = value; }
        }

        public static string creercode_f()
        {
            Program.seConnecter();
            MySqlCommand cmd = new MySqlCommand("SELECT code_f FROM facture ORDER BY code_f DESC LIMIT 1", Program.con);
            string nb = cmd.ExecuteScalar().ToString();

            string nf = nb.Substring(2);
            int ng = Int32.Parse(nf);
            ng = ng + 1;
            string nh = "FT00" + ng.ToString();

            return nh;

        }

        public static void afficherdedomages()
        {
            string req = "SELECT * FROM facture";
            string cnx = "database=pressingconjecture; datasource=localhost; userid=root; password= ";
            MySqlDataAdapter adp = new MySqlDataAdapter(req, cnx);

            adp.Fill(Factures.tablesfactures);


        }
    }
}
