using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Cartes
    {
        public string couleur
        {
            get; set;
        } = "Inconnue";
        public string carte
        {
            get; set;
        } = "Inconnue";
        
        public Cartes(string _carte, string _couleur)
        {
            couleur = _couleur;
            carte = _carte;
        }
        public Cartes(string _carte)
        {
            carte = _carte;
           
        }
        public void affiche()
        {
             Console.WriteLine("Carte :{0}  Couleur:{1}", carte, couleur);
        }

    }
}
