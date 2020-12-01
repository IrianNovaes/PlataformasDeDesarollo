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
    public class AdmTipoTarea
    {
        private string con = "https://localhost:44353/api/";


        public async Task<TipoTarea> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetTipoTarea(id);

        }

        public async Task<List<TipoTarea>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetAllTipoTarea();
        }

        public async Task<TipoTarea> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.DeleteTipoTarea(id);
        }

        public async Task<TipoTarea> Update(int id, TipoTarea valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.UpdateTipoTarea(id, valor);
        }

        public async Task<TipoTarea> Create(TipoTarea valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.CreateTipoTarea(valor);
        }
    }
}
