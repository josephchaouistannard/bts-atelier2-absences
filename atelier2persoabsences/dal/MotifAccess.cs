using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atelier2persoabsences.model;

namespace atelier2persoabsences.dal
{
    /// <summary>
    /// Classe pour accèder au table Motif de la base de données
    /// </summary>
    public class MotifAccess
    {
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de MotifAccess qui donne accès au singleton Access
        /// </summary>
        public MotifAccess()
        {
            this.access = Access.GetInstance();
        }

    }
}
