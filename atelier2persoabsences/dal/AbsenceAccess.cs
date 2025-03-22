using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2persoabsences.dal
{
    /// <summary>
    /// Classe pour accèder au table Absence de la base de données
    /// </summary>
    public class AbsenceAccess
    {
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de AbsenceAccess qui donne accès au singleton Access
        /// </summary>
        public AbsenceAccess()
        {
            this.access = Access.GetInstance();
        }
    }
}
