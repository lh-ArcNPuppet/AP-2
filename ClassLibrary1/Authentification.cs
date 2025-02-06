using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using LIB_BLL;

namespace LIB_DAL
{
    public static class Authentification
    {
        public static string ToSHA256(string input)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static UserList checkUser(string username, string password)
        {
            string sql = "select * from Magasin where username = " ;
            try
            {
                dr = cmd.ExecuteReader();

                dr.Read();

                UserList u = new UserList(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));

                dr.Close();
                return u;
            }
            catch
            {
                return null;
            }
        }
    }
}
