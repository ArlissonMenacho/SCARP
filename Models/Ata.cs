
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCARP.Models
{
    public class Ata
    {
        public string codigoAta { get; set; }
        public int anoAta { get; set; }
        public string numeroProcesso { get; set; }
        public string tipoPregao { get; set; }
        public string numeroPregao { get; set; }
        public int anoPregao { get; set; }
        public DateTime dataHomologacao { get; set; }
        public DateTime dataPublicacao { get; set; }
        public DateTime dataFinalVigencia { get; set; }
        public string ObjetoResumido { get; set; }
        public string UrlAta { get; set; }
        public string UrlEdital { get; set; }
        public bool Publicada { get; set; }
        public DateTime dataPublicacaoSistema { get; set; }
        public string observacao { get; set; }
        public string usuarioCadastrado { get; set; }
        public DateTime dataCadastro { get; set; }
        public string usuarioAlteracao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public int limiteAdesao { get; set; }


    }
}
