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
    public class AdmRol
    {
        private string con = "https://localhost:44353/api/";


        public async Task<Rol> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetRol(id);

        }

        public async Task<List<Rol>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetAllRol();
        }

        public async Task<Rol> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.DeleteRol(id);
        }

        public async Task<Rol> Update(int id, Rol valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.UpdateRol(id, valor);
        }

        public async Task<Rol> Create(Rol valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.CreateRol(valor);
        }
    }
}
