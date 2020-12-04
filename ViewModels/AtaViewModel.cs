using SCARP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCARP.ViewModels
{
    public class AtaViewModel
    {
        public int? CodigoAta { get; set; }
        public int? Ano { get; set; }
        public string NumeroPregao { get; set; }
        public double LimiteAdesao { get; set; }
        public string ObjetoResumido { get; set; }
        public DateTime DataFinalVigencia { get; set; }
    }
}
