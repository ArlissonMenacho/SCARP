using SCARP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCARP.ViewModels
{
    public class ItemViewModel
    {
        public Ata ObjAta { get; set; }
        public long CodigoMaterial { get; set; }
        public ItemCatalogo itemCatalogo { get; set; }
    }
}
