// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\Pages\Usuarios\Editar.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usuarios/editar/{id:int}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\20201020\BlazorApp1\BlazorApp1\Pages\Usuarios\Editar.razor"
       
    [Parameter]
    public int Id { get; set; }

    public Usuario Modelo { get; set; } = new Usuario();
    
    public string RolId { get; set; }
    
    public DateTime fecha { get; set; }

    private List<Rol> roles;


    protected override async Task OnInitializedAsync()
    {
        if (Id > 0)
        {
            Modelo = await service.Get(Id);
            RolId = Modelo.RolId.ToString();

        }
        else
        {
            Modelo = new Usuario();
        }
        roles = await service.GetRoles();
    }


    private async void Guardar()
    {
        Modelo.RolId = int.Parse(RolId);
        await service.Save(Modelo);
        navigation.NavigateTo("usuarios/listado");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioService service { get; set; }
    }
}
#pragma warning restore 1591