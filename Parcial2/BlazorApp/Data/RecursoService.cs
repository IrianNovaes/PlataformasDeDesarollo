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
    public class RecursoService
    {
        private readonly IRemoteService remoteService = RestService.For<IRemoteService>("https://localhost:44370/api/");


        public async Task<Recurso> Get(int id)
        {
         
            return await remoteService.GetRecurso(id);

        }

        public async Task<List<Recurso>> GetAll()
        {
          
            return await remoteService.GetAllRecurso();
        }

        public async Task<Recurso> Delete(int id)
        {
           
            return await remoteService.DeleteRecurso(id);
        }

        public async Task<Recurso> Update(int id, Recurso valor)
        {
            
            return await remoteService.UpdateRecurso(id, valor);
        }

        public async Task<Recurso> Create(Recurso valor)
        {
            
            return await remoteService.CreateRecurso(valor);
        }
    }
}
