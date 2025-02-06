using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using LIB_BLL;
using LIB_DAL;

namespace LIB_DAL
{
    public class DB_Article
    {
        public static List<Article> getAllMagasins()
        {
            List<Article> res = new List<Article>();
            SqlCommand cmd = new SqlCommand() ;
            SqlDataReader dr;
            DB_Connect.afficherConnection();
            cmd.Connection = DB_Connect.cnt;
            cmd.CommandText = "select * from Article";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Article a = new Article(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
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

        public static int ajouterArticle(Article a)
        {
            string sql = "insert into Article (reference, libelle, categorie, fabricant, unite) values (" + a.getReference() + ", '" + a.getLibelle() + ", '" + a.getCategorie() + ", '" + a.getFabricant() + ", '" + a.getUnite() + "');";
            SqlDataReader dr = DB_Connect.query(sql);
            if( dr != null )
            { 
                dr.Read();
                dr.Close();
                return 1;
            }
            return 0;
        }

        public static int supprimer(string r)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = DB_Connect.cnt;
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
