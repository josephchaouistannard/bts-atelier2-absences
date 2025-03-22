using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atelier2persoabsences.model;

namespace atelier2persoabsences.dal
{
    /// <summary>
    /// Classe pour accèder au table Personnel de la base de données
    /// </summary>
    public class PersonnelAccess
    {
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de PersonnelAccess qui donne accès au singleton Access
        /// </summary>
        public PersonnelAccess()
        {
            this.access = Access.GetInstance();
        }

    }
}
