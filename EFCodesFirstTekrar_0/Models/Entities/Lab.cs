using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Models.Entities
{
    public class Lab:BaseEntity
    {
        public string No { get; set; }
        public string Kat { get; set; }

        //Relational Properties
        public virtual List<Ders> Dersler { get; set; }

    }
}
