using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atelier2persoabsences.model;

namespace atelier2persoabsences.dal
{
    public class ServiceAccess
    {
        private readonly Access access = null;

        public ServiceAccess()
        {
            this.access = Access.GetInstance();
        }

    }
}
