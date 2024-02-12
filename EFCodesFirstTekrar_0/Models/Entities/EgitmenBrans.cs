using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Models.Entities
{
    public class EgitmenBrans:BaseEntity
    {
        public int EgitmenID { get; set; }
        public int BransID { get; set; }

        //Relational Properties
        public virtual Egitmen Egitmen { get; set; }
        public virtual Brans Brans { get; set; }

    }
}
