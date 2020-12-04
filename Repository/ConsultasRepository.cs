using Newtonsoft.Json;
using SCARP.Models;
using SCARP.Repository.Interfaces;
using SCARP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SCARP.Repository
{
    public class ConsultasRepository : IConsultasRepository
    {
        public IList<Ata> ConsultaAta(int numeroDaAta, int anoDaAta)
        {
            IList<Ata> objAta = new List<Ata>();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri($"http://localhost:64270/api/Consulta/{numeroDaAta}/{anoDaAta}");

                string resultado = string.Empty;

                var consulta = client.GetAsync(client.BaseAddress).Result;

                resultado = consulta.Content.ReadAsStringAsync().Result;

                foreach (var item in resultado)
                {
                    objAta = JsonConvert.DeserializeObject<List<Ata>>(item.ToString());
                }

                return objAta;
            }
        }
    }
}
