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
        public int Idmotif { get; }
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur de la classe Motif
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            Idmotif = idmotif;
            Libelle = libelle;
        }

        /// <summary>
        /// Resprentation d'instance de Motif sous forme de chaine
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Libelle;
        }
    }
}
