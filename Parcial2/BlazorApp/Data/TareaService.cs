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
    public class TareaService
    {
        private readonly IRemoteService remoteService = RestService.For<IRemoteService>("https://localhost:44370/api/");

        public async Task<Tarea> Get(int id)
        {
            
            return await remoteService.GetTarea(id);

        }

        public async Task<List<Tarea>> GetAll()
        {
            
            return await remoteService.GetAllTarea();
        }

        public async Task<Tarea> Delete(int id)
        {
           
            return await remoteService.DeleteTarea(id);
        }

        public async Task<Tarea> Update(int id, Tarea valor)
        {
         
            return await remoteService.UpdateTarea(id, valor);
        }

        public async Task<Tarea> Create(Tarea valor)
        {
           
            return await remoteService.CreateTarea(valor);
        }
    }

}
