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
        /// <summary>
        /// Correspond au champ idservice de la table Service
        /// </summary>
        public int Idservice { get; }

        /// <summary>
        /// Correspond au champ nom de la table Service
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Constructeur de la classe Service
        /// </summary>
        /// <param name="idservice">ID de la service</param>
        /// <param name="nom">Nom de la service</param>
        public Service(int idservice, string nom)
        {
            Idservice = idservice;
            Nom = nom;
        }

        /// <summary>
        /// Representer une instance de la classe sous forme de chaine
        /// </summary>
        /// <returns>Nom de la service</returns>
        public override string ToString()
        {
            return Nom;
        }
    }
}
