// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Roles\Details.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Roles\Details.razor"
using Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roles/details/{id:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Panny\source\repos\PlataformasDeDesarollo\Parcial2\BlazorApp\Pages\Roles\Details.razor"
       

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
