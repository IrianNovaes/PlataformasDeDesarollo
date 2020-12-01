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
        private string con = "https://localhost:44353/api/";


        public async Task<Tarea> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetTarea(id);

        }

        public async Task<List<Tarea>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetAllTarea();
        }

        public async Task<Tarea> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.DeleteTarea(id);
        }

        public async Task<Tarea> Update(int id, Tarea valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.UpdateTarea(id, valor);
        }

        public async Task<Tarea> Create(Tarea valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.CreateTarea(valor);
        }
    }

}
