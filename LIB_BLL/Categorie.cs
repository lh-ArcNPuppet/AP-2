using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Categorie {
        //Attributs privé
        private string code;
        private string libelle;

        //Constructeur
        public Categorie (string code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;
        }

        //Accesseurs - Getters
        public string getCode() { return code; }
        public string getlibelle() { return libelle; }

        //Accesseurs - Setters
        public void setCode(string code) { this.code = code; }
        public void setLibelle(string nom) { this.libelle = nom; }
    }
}
