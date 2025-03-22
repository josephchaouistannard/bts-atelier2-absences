using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2persoabsences.model
{
    public class Absence
    {
        public Personnel Personnel { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Motif Motif { get; set; }
        
        public Absence(Personnel personnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            Personnel = personnel;
            Datedebut = datedebut;
            Datefin = datefin;
            Motif = motif;
        }
    }
}
