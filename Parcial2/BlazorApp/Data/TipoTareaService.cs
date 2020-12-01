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
    public class TipoTareaService
    {
        
        private readonly IRemoteService remoteService = RestService.For<IRemoteService>("https://localhost:44370/api/");

        public async Task<TipoTarea> Get(int id)
        {
            
            return await remoteService.GetTipoTarea(id);

        }

        public async Task<List<TipoTarea>> GetAll()
        {
            
            return await remoteService.GetAllTipoTarea();
        }

        public async Task<TipoTarea> Delete(int id)
        {
            
            return await remoteService.DeleteTipoTarea(id);
        }

        public async Task<TipoTarea> Update(int id, TipoTarea valor)
        {
           
            return await remoteService.UpdateTipoTarea(id, valor);
        }

        public async Task<TipoTarea> Create(TipoTarea valor)
        {
            
            return await remoteService.CreateTipoTarea(valor);
        }
    }
}
