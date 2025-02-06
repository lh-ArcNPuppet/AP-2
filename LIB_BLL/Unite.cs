using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Unite
    {
        //Attributs privé
        private string code;
        private string libelle;

        //Constructeur
        public Unite (string code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;
        }

        //Accesseur - Getters
        public string getCode() { return code; }
        public string getLibelle() { return libelle; }

        //Accesseur - Setters
        public void setCode(string code) { this.code = code; }
        public void setLibelle(string libelle) { this.libelle = libelle; }
    }
}
