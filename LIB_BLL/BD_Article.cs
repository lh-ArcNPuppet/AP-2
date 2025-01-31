using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class BD_Article
    {
        //Attributs privé
        private string reference;
        private string libelle;
        private string categorie;
        private string fabricant;
        private string unite;

        //Constructeur
        public BD_Article(string r, string lib, string cat, string fab, string unit)
        { 
            this.reference = r;
            this.libelle = lib;
            this.categorie = cat;
            this.fabricant = fab;
            this.unite = unit;
        }

        //Accesseurs - Getter
        public string getReference() { return reference; }
        public string getLibelle() {  return libelle; }
        public string getCategorie() {  return categorie; }
        public string getFabricant() {  return fabricant; }
        public string getUnite() {  return unite; }

        //Accesseur - Setter
        public void setReference(string reference) { this.reference = reference; }
        public void setLibelle(string libelle) { this.libelle = libelle; }
        public void setCategorie(string categorie) { this.categorie = categorie; }
        public void setFabricant(string fabricant) { this.fabricant = fabricant; }
        public void setUnite(string unite) { this.unite = unite; }
    }
}
