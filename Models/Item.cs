﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCARP.Models
{
    public class Item
    {
        public Ata ObjAta { get; set; }
        public long CodigoMaterial { get; set; }
        public ItemCatalogo itemCatalogo { get; set; }
    }
}
