using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Refit;


namespace WebApplication1.Controllers
{
    public class AdmRecurso
    {
        private string con = "https://localhost:44353/api/";


        public async Task<Recurso> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetRecurso(id);

        }

        public async Task<List<Recurso>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetAllRecurso();
        }

        public async Task<Recurso> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.DeleteRecurso(id);
        }

        public async Task<Recurso> Update(int id, Recurso valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.UpdateRecurso(id, valor);
        }

        public async Task<Recurso> Create(Recurso valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.CreateRecurso(valor);
        }
    }
}
