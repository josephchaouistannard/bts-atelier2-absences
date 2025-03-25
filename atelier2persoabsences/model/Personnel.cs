using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2persoabsences.model
{
    /// <summary>
    /// Classe representant une ligne de la table Personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Correspond au champ idpersonnel de la table Personnel
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// Correspond au champ nom de la table Personnel
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Correspond au champ prenom de la table Personnel
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Correspond au champ tel de la table Personnel
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Correspond au champ mail de la table Personnel
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Correspond au champ idservice de la table Personnel
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Constructeur de la classe Personnel
        /// </summary>
        /// <param name="idpersonnel">ID de la personne</param>
        /// <param name="nom">Nom de la personne</param>
        /// <param name="prenom">Prenom de la personne</param>
        /// <param name="tel">Numéro téléphone de la personne</param>
        /// <param name="mail">Adresse mail de la personne</param>
        /// <param name="service">ID de la service à laquelle appartient la personne</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            Idpersonnel = idpersonnel;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            Service = service;
        }
    }
}
