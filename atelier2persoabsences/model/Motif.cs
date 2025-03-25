using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2persoabsences.model
{
    /// <summary>
    /// Classe representant une ligne de la table Motif
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Correspond au champ idmotif de la table Motif
        /// </summary>
        public int Idmotif { get; }

        /// <summary>
        /// Correspond au champ libelle de la table Motif
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur de la classe Motif
        /// </summary>
        /// <param name="idmotif">ID du motif</param>
        /// <param name="libelle">Libelle du motif</param>
        public Motif(int idmotif, string libelle)
        {
            Idmotif = idmotif;
            Libelle = libelle;
        }

        /// <summary>
        /// Resprentation d'instance de Motif sous forme de chaine
        /// </summary>
        /// <returns>Libelle du motif</returns>
        public override string ToString()
        {
            return Libelle;
        }
    }
}
