using EFCodesFirstTekrar_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Configurations
{
    public abstract class BaseConfiguration<T>  : EntityTypeConfiguration<T> where T:BaseEntity
    {
        public BaseConfiguration()
        {
            Property(x => x.ModifiedDate).HasColumnName("Guncelleme Tarihi");
            Property(x => x.CreatedDate).HasColumnName("Yaratılma Tarihi");
            Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
            Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
