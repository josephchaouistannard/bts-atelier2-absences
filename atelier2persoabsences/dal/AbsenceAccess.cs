using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2persoabsences.dal
{
    public class AbsenceAccess
    {
        private readonly Access access = null;

        public AbsenceAccess()
        {
            this.access = Access.GetInstance();
        }
    }
}
