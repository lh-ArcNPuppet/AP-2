using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using LIB_BLL;
using LIB_DAL;

namespace ClassLibrary1
{
    public class DB_Article
    {
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
