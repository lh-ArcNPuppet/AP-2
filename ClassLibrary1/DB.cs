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

        public static List<BD_Article> getAllMagasins()
        {
            List<BD_Article> res = new List<BD_Article>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = cnt;
            cmd.CommandText = "select * from Article";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BD_Article a = new BD_Article(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
                    res.Add(a);
                }
                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }
        }

        public static int ajouterArticle(BD_Article a)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = cnt;
            cmd.CommandText = "insert into Article (reference, libelle, categorie, fabricant, unite) values (" + a.getReference() + ", '" + a.getLibelle() + ", '" + a.getCategorie() + ", '" + a.getFabricant() + ", '" + a.getUnite() + "');";
            try
            {
                dr = cmd.ExecuteReader();
                dr.Read();


                dr.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int supprimer(string r)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = cnt;
            cmd.CommandText = "delete from Article where reference = " + r;
            try
            {
                dr = cmd.ExecuteReader();
                dr.Read();


                dr.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
