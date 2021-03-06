// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Usuarios\List.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Usuarios\List.razor"
using Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usuarios/list")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Usuarios\List.razor"
       
    private List<Usuario> usuarios;

    protected override async Task OnInitializedAsync()
    {
        var valor = new Usuario();
        valor.Nombre = "test";
        await service.Create(valor);
        usuarios = await service.GetAll();

    }

    protected void Edit(int id)
    {
        navigation.NavigateTo("usuarios/edit/" + id);
    }

    protected void Details(int id)
    {
        navigation.NavigateTo("usuarios/details/" + id);
    }

    protected void Create()
    {
        navigation.NavigateTo("usuarios/create/");
    }

    async Task Erase(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar el usuario?");

        if (confirmed)
        {
            await service.Delete(id);
            usuarios = await service.GetAll();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioService service { get; set; }
    }
}
#pragma warning restore 1591
