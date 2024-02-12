using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Models.Entities
{
    public class Ders:BaseEntity
    {
        public string MufredatAciklamasi { get; set; }
        public int? EgitmenID { get; set; }
        public int? LabID { get; set; }


        //Relational Properties
        public virtual List<OgrenciDers> OgrenciDersleri { get; set; }
        public virtual Egitmen Egitmen { get; set; }
        public virtual Lab Lab { get; set; }

       


    }
}
