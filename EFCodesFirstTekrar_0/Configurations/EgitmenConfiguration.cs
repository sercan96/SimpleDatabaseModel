using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodesFirstTekrar_0.Models.Entities;

namespace EFCodesFirstTekrar_0.Configurations
{
    public class EgitmenConfiguration : PropSpecConfiguration<Egitmen>
    {
        public EgitmenConfiguration()
        {
            ToTable("Egitmenler");
        }
    }
}
