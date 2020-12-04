using SCARP.Models;
using SCARP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCARP.Helpers
{
    public static class AtaExtensions
    {
        public static Ata ConverterDeViewModelParaModel(this AtaViewModel ataViewModel)
        {
            return new Ata
            {
                Ano = ataViewModel.Ano,
                CodigoAta = ataViewModel.CodigoAta,
                NumeroPregao = ataViewModel.NumeroPregao,
                LimiteAdesao = ataViewModel.LimiteAdesao,
                ObjetoResumido = ataViewModel.ObjetoResumido,
                DataFinalVigencia = ataViewModel.DataFinalVigencia
            };
        }

        public static AtaViewModel ConverterDeModelParaViewModel(this Ata ata)
        {
            return new AtaViewModel
            {
                Ano = ata.Ano,
                CodigoAta = ata.CodigoAta,
                NumeroPregao = ata.NumeroPregao,
                LimiteAdesao = ata.LimiteAdesao,
                ObjetoResumido = ata.ObjetoResumido,
                DataFinalVigencia = ata.DataFinalVigencia
            };
        }
    }
}