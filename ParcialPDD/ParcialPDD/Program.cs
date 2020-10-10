using System;
using System.Collections.Generic;
using System.Linq;

namespace ParcialPDD
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        static void RunApp()
        {
            string nombreOpcion;

                Console.WriteLine("Ingrese el numero de la accion que deseas ejecutar: \r\n" +
                                   "1 - Insertar \r\n" +
                                   "2 - Consultar \r\n" +
                                   "3 - Actualizar \r\n" +
                                   "4 - Borrar \r\n" +
                                   "0 - Salir ");
                                   
              int opcionAccion = int.Parse(Console.ReadLine());

            if(opcionAccion != 0 && opcionAccion < 5) { 
                    switch (opcionAccion)
                    {
                        case 1: nombreOpcion = "Insertar";
                            break;
                        case 2:  nombreOpcion = "Consultar";
                            break;
                        case 3:  nombreOpcion = "Actualizar";
                            break;
                        case 4:  nombreOpcion = "Borrar";
                            break;
                        default: nombreOpcion = " ";
                            break;

                    }

                Console.WriteLine(opcionAccion == 2 ? 
                                   $"\r\n{opcionAccion} - {nombreOpcion}:\r\n " +
                                  "Ingrese el numero de la tabla: \r\n" +
                                  "1 - Tareas \r\n" +
                                  "2 - Usuarios \r\n" +
                                  "3 - Recursos \r\n" +
                                  "4 - Detalles \r\n" +
                                  "5 - Todos \r\n" +
                                  "0 - Salir" 
                                  :
                                   $"\r\n{opcionAccion} - {nombreOpcion}:\r\n " +
                                  "Ingrese el numero de la tabla: \r\n" +
                                  "1 - Tareas \r\n" +
                                  "2 - Usuarios \r\n" +
                                  "3 - Recursos \r\n" +
                                  "4 - Detalles \r\n" +
                                  "0 - Salir"
                                  );
            }
            else {
                Console.WriteLine("Okay, Hasta la Proxima");
                  Environment.Exit(0);
            }

            int opcionTable = int.Parse(Console.ReadLine());

            if((opcionTable == 2 && opcionTable < 6)||(opcionTable != 0 && opcionTable < 5))
            {
                SelectAction(opcionAccion, opcionTable);
            } else
            {
                Console.WriteLine("Okay, Hasta la Proxima");
                Environment.Exit(0);
            }

        }

        static void SelectAction(int a, int t)
        {
            switch (a)
            {
                case 1:
                    Insertar(t);
                    break;
                case 2:
                    if (t != 5) { Consultar(t); } else { ConsultarAll(); }
                    break;
                case 3:
                    Actualizar(t);
                    break;
                case 4:
                     Borrar(t);
                    break;
                default:
                    break;
            }
        }

        static void Insertar(int t)
        {
            var ctx = new TareasDbContext();
            Console.WriteLine("Un registro predefinido será incluido en la tabla seleccionada.");
            switch (t)
            {
                //Tareas
                case 1:
                    ctx.Tareas.Add(new Tareas
                    {
                        Titulo = "Una Tarea",
                        Vencimiento = new DateTime(2020/12/01),
                        Estimacion = 60,
                        Responsable = new Recursos("Nombre Recurso", new Usuarios ("Lola", "2222")), 
                        Estado = true
                    });
                    break;
                //Usuarios
                case 2:
                    ctx.Usuarios.Add(new Usuarios
                    {
                        Usuario = "Gabriel",
                        Clave = "1234"
                    });
                    break;
                //Recursos
                case 3:
                    ctx.Recursos.Add(new Recursos("Recurso", new Usuarios("Bob", "2343212")));

                    break;
                //Detalles
                case 4:
                    Recursos recurso = new Recursos("Recurso", new Usuarios("Yo", "2343212"));
                    ctx.Detalles.Add(new Detalles { 
                        Fecha = new DateTime(2020/10/10),
                        Tiempo = 24,
                        Recurso = recurso,
                        Tarea = new Tareas("Terminar app", new DateTime(2020/10/10), 24,recurso, true )
                    });
                    break;
                default:
                    Console.WriteLine("Hubo un error intente nuevamente.");
                    break;
            }


            ctx.SaveChanges();
        }

        static void Actualizar(int t)
        {
            var ctx = new TareasDbContext();
            //Console.WriteLine("Ingrese el ID del registro que queres actualizar:");
            //int id = int.Parse(Console.ReadLine());

            switch (t)
            {
                //Tareas
                case 1:
                    var tarea = ctx.Tareas.Where(i => i.TareaPK == 1).ToList();
                    tarea[0].Titulo = "Finalizar App";
                    break;
                //Usuarios
                case 2:
                    var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == 1).ToList();
                    usuario[0].Usuario = "Fabi";
                    break;
                //Recursos
                case 3:
                   //Finalizar seccion 
                    break;
                //Detalles
                case 4:
                    //Finalizar seccion  
                    break;
                default:
                    Console.WriteLine("Hubo un error intente nuevamente.");
                    break;
            }


            ctx.SaveChanges();
        }

        

        static void Consultar(int t)
        {
            var ctx = new TareasDbContext();
            var listUser = ctx.Usuarios.ToList();
            var listTasks = ctx.Tareas.ToList();
            var listResources = ctx.Recursos.ToList();
            var listDetails = ctx.Detalles.ToList();

            switch (t)
            {
                case 1:
                    Console.WriteLine("------------------- Tareas ----------------");
                    foreach (var item in listTasks)
                    {
                        
                        Console.WriteLine($"Id: {item.TareaPK} Titulo: {item.Titulo} Vencimiento: {item.Vencimiento} Responsable: {item.Responsable}");
                    }
                    break;
                case 2:
                    Console.WriteLine("------------------- Usuarios ----------------");
                    foreach (var item in listUser)
                    {
                        Console.WriteLine($"UserName: {item.Usuario} Id: {item.UsuarioPK}");
                    }
                    break;
                case 3:
                    Console.WriteLine("------------------- Recursos ----------------");
                    foreach (var item in listResources)
                    {
                        Console.WriteLine($"Nombre: {item.Nombre} Usuario: {item.Usuario}");
                    }
                    break;
                case 4:
                    Console.WriteLine("------------------- Detalles ----------------");
                    foreach (var item in listDetails)
                    {
                        Console.WriteLine($"Fecha: {item.Fecha} Vencimiento: {item.Tiempo} Tarea: {item.Tarea.Titulo} ({item.Tarea.TareaPK})");
                    }
                    break;
                default:
                    break;

            }

        }
        static void ConsultarAll() {
            var ctx = new TareasDbContext();
            var listUser = ctx.Usuarios.ToList();
            var listTasks = ctx.Tareas.ToList();
            var listResources = ctx.Recursos.ToList();
            var listDetails = ctx.Detalles.ToList();

            if (listUser.Count != 0 && listTasks.Count != 0 && listResources.Count != 0 && listDetails.Count != 0) {

                Console.WriteLine("------------------- Usuarios ----------------");
                foreach (var item in listUser)
                {
                    Console.WriteLine($"UserName: {item.Usuario} Id: {item.UsuarioPK}");
                }

                Console.WriteLine("------------------- Tareas ----------------");

                foreach (var item in listTasks)
                {
                    Console.WriteLine($"Titulo: {item.Titulo} Vencimiento: {item.Vencimiento} Responsable: {item.Responsable}");
                }
                
                Console.WriteLine("------------------- Recursos ----------------");
                foreach (var item in listResources)
                {
                    Console.WriteLine($"Nombre: {item.Nombre} Usuario: {item.Usuario}");
                }
                
                Console.WriteLine("------------------- Detalles ----------------");
                foreach (var item in listDetails)
                {
                    Console.WriteLine($"Fecha: {item.Fecha} Vencimiento: {item.Tiempo} Tarea: {item.Tarea.Titulo} ({item.Tarea.TareaPK})");
                }

            }
            else
            {
                Console.WriteLine($"Una o mas tablas estan vacias, ingrese valores antes de seguir");
            }
            
        }

        static void Borrar(int t)
        {
            var ctx = new TareasDbContext();

            Console.WriteLine("Ingrese el numero corespondiente a la accion que deseas executar: \r\n 1 - Borrar unico registro \r\n 2 - Borrar tabla \r\n 0 - Salir");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese el ID del registro que queres borrar:");
                int id = int.Parse(Console.ReadLine());

                switch (t)
                {
                    //Tareas
                    case 1:
                        var tarea = ctx.Tareas.Where(i => i.TareaPK == id).Single();
                        ctx.Tareas.Remove(tarea);
                        break;
                    //Usuarios
                    case 2:
                        var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == id).Single();
                        ctx.Usuarios.Remove(usuario);
                        break;
                    //Recursos
                    case 3:
                        var recurso = ctx.Recursos.Where(i => i.RecursoPK == id).Single();
                        ctx.Recursos.Remove(recurso);
                        break;
                    //Detalles
                    case 4:
                        var detalle = ctx.Detalles.Where(i => i.DetallePK == id).Single();
                        ctx.Detalles.Remove(detalle);
                        break;
                    default:
                        Console.WriteLine("Hubo un error intente nuevamente.");
                        break;
                }
            }
            else if (opcion == 2)
            {
                switch (t)
                {
                    //Tareas
                    case 1:
                        ctx.Remove("Tareas");
                        break;
                    //Usuarios
                    case 2:
                        ctx.Remove("Usuarios");
                        break;
                    //Recursos
                    case 3:
                        ctx.Remove("Recursos");
                        break;
                    //Detalles
                    case 4:
                        ctx.Remove("Detalles");
                        break;
                    default:
                        Console.WriteLine("Hubo un error intente nuevamente.");
                        break;
                }

            } else { 
                Console.WriteLine("Okay, Hasta la Proxima");
                Environment.Exit(0);
            }

            ctx.SaveChanges();
        }

        
    }
}
