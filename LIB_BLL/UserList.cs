using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class UserList
    {
        //Attributs privés
        private int id;
        private string identifiant;
        private string pswd;

        //Constructeur
        public UserList (int id,string identifiant, string pswd)
        {
            this.id = id;
            this.identifiant = identifiant;
            this.pswd = pswd;
        }

        //Accesseurs - Getter
        public int getId() { return id; }
        public string getIdentifiant() {  return identifiant; }
        public string getPassword() { return pswd; }

        //Accesseurs - Setter
        public void setPassword(string pswd) { this.pswd = pswd; }
    }
}
