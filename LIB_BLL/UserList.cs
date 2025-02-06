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
        private string id;
        private string pswd;

        //Constructeur
        public UserList (string id, string pswd)
        {
            this.id = id;
            this.pswd = pswd;
        }

        //Accesseurs - Getter
        public string getIdentification() { return id; }
        public string getPassword() { return pswd; }
    }
}
