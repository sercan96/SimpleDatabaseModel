using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Models.Entities
{
    public class Egitmen:PropSpec
    {
      

        //Relational Properties
        public virtual List<EgitmenBrans> EgitmenBranslari { get; set; }
        public virtual List<Ders> Dersler { get; set; }


    }
}
