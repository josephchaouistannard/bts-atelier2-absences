using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atelier2persoabsences.model;

namespace atelier2persoabsences.dal
{
    /// <summary>
    /// Classe pour accèder au table Service de la base de données
    /// </summary>
    public class ServiceAccess
    {
        private readonly Access access = null;

        /// <summary>
        /// Constructeur de ServiceAccess qui donne accès au singleton Access
        /// </summary>
        public ServiceAccess()
        {
            this.access = Access.GetInstance();
        }

    }
}
