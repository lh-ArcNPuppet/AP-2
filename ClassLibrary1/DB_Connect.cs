using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LIB_BLL;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DB_Connect
    {
        private static bool connecte = false;
        public static SqlConnection cnt;
        public DB_Connect() { }
        public static bool openConnection()
        {
            cnt = new SqlConnection();

            //Informations de connexion au serveur SQL Server
            string dataSource = "Data Source=" + "SRV-SQL\\SQL_SLAM";
            string initialCatalog = "Initial Catalog=" + "BD_STOCK2";
            string integratedSecurity = "Integrated Security=" + "SSPI";

            cnt.ConnectionString = dataSource + ";" + initialCatalog + ";" + integratedSecurity;
            try
            {
                cnt.Open();
                connecte = true;
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
        public static void fermerConnexion()
        {
            cnt.Close();
            connecte = false;
        }

        public static SqlDataReader query(string sql)
        {
            if (connecte)
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.Connection = cnt;
                cmd.CommandText = sql;
                try
                {
                    dr = cmd.ExecuteReader();
                    return dr;
                }
                catch (Exception erreur)
                {
                    return null;
                }
            }
            return null;
        }
    }
}
