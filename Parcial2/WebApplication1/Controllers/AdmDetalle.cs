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
    public class AdmDetalle
    {
        private string con = "https://localhost:44353/api/";


        public async Task<Detalle> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetDetalle(id);

        }

        public async Task<List<Detalle>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalle> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.DeleteDetalle(id);
        }

        public async Task<Detalle> Update(int id, Detalle valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.UpdateDetalle(id, valor);
        }

        public async Task<Detalle> Create(Detalle valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.CreateDetalle(valor);
        }
    }
}
