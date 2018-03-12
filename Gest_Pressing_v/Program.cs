using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionPressing
{
    public class UpdateTextBoxEventArgs : EventArgs
    {
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }

        public UpdateTextBoxEventArgs(string text)
        {
            this.text = text;
        }
    }
    static class Program
    {
        public static string mle = "";
        public static string menu = "client";
        public static MySqlConnection con;
        public static void seConnecter()
        {
            con = new MySqlConnection();
            con.ConnectionString = "database=pressingconjecture; datasource=localhost; userid=root; password= ";
            con.Open();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {/*
            Random telph = new Random();
            string n0 = telph.Next(5, 9).ToString();
            string n1 = telph.Next(0, 9).ToString();
            string n2 = telph.Next(0, 9).ToString();
            string n3 = telph.Next(0, 9).ToString();
            string n4 = telph.Next(0, 9).ToString();
            string n5 = telph.Next(0, 9).ToString();
            string n6 = telph.Next(0, 9).ToString();
            string n7 = telph.Next(0, 9).ToString();

            string t = "6" + n0 + n1 + n2 + n3 + n4 + n5 + n6 + n7;
            Console.WriteLine(t);
            Console.ReadLine();
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formulairevetement());
        }
    }
}
