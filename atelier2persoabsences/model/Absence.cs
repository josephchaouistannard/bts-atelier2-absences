using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2persoabsences.model
{
    /// <summary>
    /// La partie modèle contenant les classes métiers
    /// </summary>
    class NamespaceDoc
    {
    }

    /// <summary>
    /// Classe representant une ligne de la table Absence
    /// </summary>
    public sealed class Absence : ICloneable
    {
        /// <summary>
        /// Correspond au champ idpersonnel de la table Absence
        /// </summary>
        public Personnel Personnel { get; set; }

        /// <summary>
        /// Correspond au champ datedebut de la table Absence
        /// </summary>
        public DateTime Datedebut { get; set; }

        /// <summary>
        /// Correspond au champ datefin de la table Absence
        /// </summary>
        public DateTime Datefin { get; set; }

        /// <summary>
        /// Correspond au champ motif de la table Absence
        /// </summary>
        public Motif Motif { get; set; }
        
        /// <summary>
        /// Constructeur pour créer une instance de la classe Absence
        /// </summary>
        /// <param name="personnel">Personne concernée par l'absence</param>
        /// <param name="datedebut">Date de début de l'absence</param>
        /// <param name="datefin">Date de fin de l'absence</param>
        /// <param name="motif">Le motif pour l'absence</param>
        public Absence(Personnel personnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            Personnel = personnel;
            Datedebut = datedebut;
            Datefin = datefin;
            Motif = motif;
        }

        /// <summary>
        /// Comprarer deux Absences utilisant leurs dates
        /// </summary>
        /// <param name="absence">Absence avec laquelle il faut comparer</param>
        /// <returns>Vrai si les dates sont les mêmes</returns>
        public bool Equals(Absence absence)
        {
            return this.Datedebut == absence.Datedebut && this.Datefin == absence.Datefin;
        }

        /// <summary>
        /// Crée une copie de l'instance, pas lié avec l'ancienne
        /// </summary>
        /// <returns>Une copie superficielle de cette instance</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
