﻿using EfCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_1.Configurations
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Kategoriler");
        }
    }
}
