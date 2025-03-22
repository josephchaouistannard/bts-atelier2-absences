using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atelier2persoabsences.model;

namespace atelier2persoabsences.dal
{
    public class PersonnelAccess
    {
        private readonly Access access = null;

        public PersonnelAccess()
        {
            this.access = Access.GetInstance();
        }

    }
}
