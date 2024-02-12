using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Models.Entities
{
    public class OgrenciDers:BaseEntity
    {
        public int DersID { get; set; }
        public int OgrenciID { get; set; }

        //Relational Properties
        public virtual Ders Ders { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }

    }
}
