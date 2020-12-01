using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using Entidades;

namespace WebApplication1.Controllers
{
    public interface IRemoteService
    {
        
        //Usuarios

        [Get("/Usuario")]
        Task<List<Usuario>> GetAllUsuario();

        [Get("/Usuario/{id}")]
        Task<Usuario> GetUsuario(int id);

        [Post("/Usuario")]
        Task<Usuario> CreateUsuario([Body] Usuario valor);

        [Put("/Usuario/{id}")]
        Task<Usuario> UpdateUsuario(int id, [Body] Usuario valor);

        [Delete("/Usuario/{id}")]
        Task<Usuario> DeleteUsuario(int id);

        //Tipo Tarea
        [Get("/TipoTarea")]
        Task<List<TipoTarea>> GetAllTipoTarea();

        [Get("/TipoTarea/{id}")]
        Task<TipoTarea> GetTipoTarea(int id);

        [Post("/TipoTarea")]
        Task<TipoTarea> CreateTipoTarea([Body] TipoTarea valor);

        [Put("/TipoTarea/{id}")]
        Task<TipoTarea> UpdateTipoTarea(int id, [Body] TipoTarea valor);

        [Delete("/TipoTarea/{id}")]
        Task<TipoTarea> DeleteTipoTarea(int id);

        //Tarea
        [Get("/Tarea")]
        Task<List<Tarea>> GetAllTarea();

        [Get("/Tarea/{id}")]
        Task<Tarea> GetTarea(int id);

        [Post("/Tarea")]
        Task<Tarea> CreateTarea([Body] Tarea valor);

        [Put("/Tarea/{id}")]
        Task<Tarea> UpdateTarea(int id, [Body] Tarea valor);

        [Delete("/Tarea/{id}")]
        Task<Tarea> DeleteTarea(int id);

        // Rol
        [Get("/Rol")]
        Task<List<Rol>> GetAllRol();

        [Get("/Rol/{id}")]
        Task<Rol> GetRol(int id);

        [Post("/Rol")]
        Task<Rol> CreateRol([Body] Rol valor);

        [Put("/Rol/{id}")]
        Task<Rol> UpdateRol(int id, [Body] Rol valor);

        [Delete("/Rol/{id}")]
        Task<Rol> DeleteRol(int id);

        // Detalle
        [Get("/Detalle")]
        Task<List<Detalle>> GetAllDetalle();

        [Get("/Detalle/{id}")]
        Task<Detalle> GetDetalle(int id);

        [Post("/Detalle")]
        Task<Detalle> CreateDetalle([Body] Detalle valor);

        [Put("/Detalle/{id}")]
        Task<Detalle> UpdateDetalle(int id, [Body] Detalle valor);

        [Delete("/Detalle/{id}")]
        Task<Detalle> DeleteDetalle(int id);

        // Recurso
        [Get("/Recurso")]
        Task<List<Recurso>> GetAllRecurso();

        [Get("/Recurso/{id}")]
        Task<Recurso> GetRecurso(int id);

        [Post("/Recurso")]
        Task<Recurso> CreateRecurso([Body] Recurso valor);

        [Put("/Recurso/{id}")]
        Task<Recurso> UpdateRecurso(int id, [Body] Recurso valor);

        [Delete("/Recurso/{id}")]
        Task<Recurso> DeleteRecurso(int id);

    }
}
