using SCARP.Models;
using SCARP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCARP.Repository.Interfaces
{
    public interface IConsultasRepository
    {
        IList<Ata> ConsultaAta(int numeroDaAta, int anoDaAta);
    }
}
