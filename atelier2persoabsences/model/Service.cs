using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2persoabsences.model
{
    /// <summary>
    /// Classe representant une ligne de la table Service
    /// </summary>
    public class Service
    {
        public int Idservice { get; }
        public string Nom { get; set; }

        /// <summary>
        /// Constructeur de la classe Service
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            Idservice = idservice;
            Nom = nom;
        }

        /// <summary>
        /// Utilise Nom pour representer une instance de la classe sous forme de chaine
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nom;
        }
    }
}
