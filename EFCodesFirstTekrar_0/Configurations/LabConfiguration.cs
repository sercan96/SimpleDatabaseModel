﻿using EFCodesFirstTekrar_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodesFirstTekrar_0.Configurations
{
    public class LabConfiguration:BaseConfiguration<Lab>
    {
        public LabConfiguration()
        {
            ToTable("Lablar");
        }
    }
}
