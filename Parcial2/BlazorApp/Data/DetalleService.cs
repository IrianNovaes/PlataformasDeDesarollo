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
    public class DetalleService
    {
        private readonly IRemoteService remoteService = RestService.For<IRemoteService>("https://localhost:44370/api/");

        public async Task<Detalle> Get(int id)
        {
             
            return await remoteService.GetDetalle(id);

        }

        public async Task<List<Detalle>> GetAll()
        {
             
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalle> Delete(int id)
        {
             
            return await remoteService.DeleteDetalle(id);
        }

        public async Task<Detalle> Update(int id, Detalle valor)
        {
             
            return await remoteService.UpdateDetalle(id, valor);
        }

        public async Task<Detalle> Create(Detalle valor)
        {
             
            return await remoteService.CreateDetalle(valor);
        }
    }
}
