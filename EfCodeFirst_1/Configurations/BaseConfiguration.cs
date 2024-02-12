using EfCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_1.Configurations
{
    public class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseConfiguration()
        {
            Property(x => x.ModifiedDate).HasColumnName("Guncelleme Tarihi");
            Property(x => x.CreatedDate).HasColumnName("Yaratılma Tarihi");
            Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
        }
    }
}
