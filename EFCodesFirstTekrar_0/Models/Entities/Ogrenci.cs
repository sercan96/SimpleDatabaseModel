using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Models.Entities
{

    //Todo: OgrenciDers manytomany 2. faz, EgitmenBrans many to many 2. faz
    public class Ogrenci:PropSpec
    {

        public int? DanismanID { get; set; }

        //Relational Properties
        public virtual Danisman Danisman { get; set; }
        public virtual List<OgrenciDers> OgrenciDersleri { get; set; }


    }
}
