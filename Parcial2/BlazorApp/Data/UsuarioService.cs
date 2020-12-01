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

        private readonly IRemoteService remoteService = RestService.For<IRemoteService>("https://localhost:44370/api/");



        public async Task<Usuario> Get(int id)
        {
             
            return await remoteService.GetUsuario(id);
            
        }

        public async Task<List<Usuario>> GetAll()
        {
             
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> Delete(int id)
        {
             
            return await remoteService.DeleteUsuario(id);
        }

        public async Task<Usuario> Update(int id, Usuario value)
        {
             
            return await remoteService.UpdateUsuario(id, value);
        }

        public async Task<Usuario> Create(Usuario valor)
        {
             
            return await remoteService.CreateUsuario(valor);
        }

    }
}
