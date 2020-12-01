using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Refit;


namespace BlazorApp.Data
{
    public class RolService
    {
        private readonly IRemoteService remoteService = RestService.For<IRemoteService>("https://localhost:44370/api/");


        public async Task<Rol> Get(int id)
        {
            
            return await remoteService.GetRol(id);

        }

        public async Task<List<Rol>> GetAll()
        {
             
            return await remoteService.GetAllRol();
        }

        public async Task<Rol> Delete(int id)
        {
             
            return await remoteService.DeleteRol(id);
        }

        public async Task<Rol> Update(int id, Rol valor)
        {
             
            return await remoteService.UpdateRol(id, valor);
        }

        public async Task<Rol> Create(Rol valor)
        {
             
            return await remoteService.CreateRol(valor);
        }
    }
}
