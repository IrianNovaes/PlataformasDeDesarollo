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
    public class UsuarioService
    {
        
        private string con = "https://localhost:44353/api/";
        

       
        public async Task<Usuario> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetUsuario(id);
            
        }

        public async Task<List<Usuario>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> Delete(int id)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.DeleteUsuario(id);
        }

        public async Task<Usuario> Update(int id, Usuario value)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.UpdateUsuario(id, value);
        }

        public async Task<Usuario> Create(Usuario valor)
        {
            var remoteService = RestService.For<IRemoteService>(con);
            return await remoteService.CreateUsuario(valor);
        }

    }
}
