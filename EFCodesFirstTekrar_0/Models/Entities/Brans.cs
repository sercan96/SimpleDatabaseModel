using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Models.Entities
{
    public class Brans:BaseEntity
    {
        public string Isim { get; set; }

        //Relational Properties
        public virtual List<EgitmenBrans> EgitmenBranslari { get; set; }

    }
}
