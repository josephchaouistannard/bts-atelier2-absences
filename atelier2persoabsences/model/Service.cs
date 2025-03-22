using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2persoabsences.model
{
    public class Service
    {
        public int Idservice { get; }
        public string Nom { get; set; }

        public Service(int idservice, string nom)
        {
            Idservice = idservice;
            Nom = nom;
        }
    }
}
