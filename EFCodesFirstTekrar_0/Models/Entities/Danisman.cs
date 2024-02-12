using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Models.Entities
{
    public class Danisman:PropSpec
    {


        //Relational Properties
        public virtual List<Ogrenci> Ogrenciler { get; set; }

    }
}
