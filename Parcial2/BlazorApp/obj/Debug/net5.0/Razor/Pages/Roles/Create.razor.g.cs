#pragma checksum "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Roles\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b36a7113ba2fc3b158b15db5b97135dc6da4000"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages.Roles
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
#line 3 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Roles\Create.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Roles\Create.razor"
using Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roles/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Crear</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Rol</h4>\r\n<hr>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"row\">\r\n    Pagina en desarollo.\r\n</div>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Roles\Create.razor"
                                  ()=>GoBack()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Volver");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Roles\Create.razor"
       

    protected void GoBack()
    {
        navigation.NavigateTo("roles/list");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RolService service { get; set; }
    }
}
#pragma warning restore 1591
