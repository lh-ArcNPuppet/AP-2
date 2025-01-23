using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LIB_BLL;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DB
    {
        private static SqlConnection cnt;
        public DB() { }
        public static bool openConnection(string DS_value, string IC_value)
        {
            cnt = new SqlConnection();

            //Informations de connexion au serveur SQL Server
            string dataSource = "Data Source=" + DS_value;
            string initialCatalog = "Initial Catalog=" + IC_value;
            string integratedSecurity = "Integrated Security=" + "SSPI";

            cnt.ConnectionString = dataSource + ";" + initialCatalog + ";" + integratedSecurity;
            try
            {
                cnt.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static string afficherConnection()
        {
            return "Connecté sur le serveur " + cnt.DataSource + " ➔ " + cnt.Database + "\nEtat = " + cnt.State;
        }
        public void fermerConnexion()
        {
            cnt.Close();
        }
    }
}
