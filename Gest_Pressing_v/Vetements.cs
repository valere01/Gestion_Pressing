using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestionPressing
{
    class Vetements
    {
        public static DataTable tablevetements = new DataTable();

        private string id;
        private string type;
        private string proprietaire;
        private string date_depot;
        private string date_disponibilite;
        private string compartiment;
        private string fiche_lavage;
        private string fiche_repassage;

        public Vetements()
        {
            this.id = "";
            this.type = "";
            this.proprietaire = "";
            this.date_depot = "";
            this.date_disponibilite = "";
            this.compartiment = "";
            this.fiche_lavage = "";
            this.fiche_repassage = "";
        }

        public Vetements(string id, string type, string proprietaire, string date_depot, string date_disponibilite, string compartiment, string fiche_lavage, string fiche_repassage)
        {
            this.id = id;
            this.type = type;
            this.proprietaire = proprietaire;
            this.date_depot = date_depot;
            this.date_disponibilite = date_disponibilite;
            this.compartiment = compartiment;
            this.fiche_lavage = fiche_lavage;
            this.fiche_repassage = fiche_repassage;
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Proprietaire
        {
            get { return this.proprietaire; }
            set { this.proprietaire = value; }
        }

        public string Date_depot
        {
            get { return this.Date_depot; }
            set { this.Date_depot = value; }
        }

        public string Date_disponibilite
        {
            get { return this.date_disponibilite; }
            set { this.date_disponibilite = value; }
        }

        public string Compartiment
        {
            get { return this.compartiment; }
            set { this.compartiment = value; }
        }

        public string Fiche_lavage
        {
            get { return this.fiche_lavage; }
            set { this.fiche_lavage = value; }
        }

        public string Fiche_repassagee
        {
            get { return this.fiche_repassage; }
            set { this.fiche_repassage = value; }
        }

        public static string creeridentifiant()
        {
            Program.seConnecter();
            MySqlCommand cmd = new MySqlCommand("SELECT identifiant FROM vetement ORDER BY identifiant DESC LIMIT 1", Program.con);
            string nb = cmd.ExecuteScalar().ToString();

            string nf = nb.Substring(2);
            int ng = Int32.Parse(nf);
            ng = ng + 1;
            string nh = "VT0" + ng.ToString();

            return nh;

        }

        public static void affichervetements()
        {
            string req = "SELECT * FROM vetement";
            string cnx = "database=pressingconjecture; datasource=localhost; userid=root; password= ";
            MySqlDataAdapter adp = new MySqlDataAdapter(req, cnx);

            adp.Fill(Vetements.tablevetements);


        }
    }
}
