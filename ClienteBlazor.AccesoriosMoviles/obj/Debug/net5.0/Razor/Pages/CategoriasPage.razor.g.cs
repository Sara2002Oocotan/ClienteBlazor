#pragma checksum "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad35425c5ebc110ae5e5cb977943aed5540fb246"
// <auto-generated/>
#pragma warning disable 1591
namespace ClienteBlazor.AccesoriosMoviles.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using ClienteBlazor.AccesoriosMoviles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using ClienteBlazor.AccesoriosMoviles.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Categoria")]
    public partial class CategoriasPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
               Typo.h3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, "Categorias");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 9 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
     foreach (var item in deptos)
    {
        string nombre = "";

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudItem>(7);
                __builder2.AddAttribute(8, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
             12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
                     10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
                             6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
                                    4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCard>(13);
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardHeader>(15);
                        __builder4.AddAttribute(16, "Class", "blue darken-1");
                        __builder4.AddAttribute(17, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(18);
                            __builder5.AddAttribute(19, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 16 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(21, 
#nullable restore
#line 16 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
                                         item.Nombre

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\n        ");
                        __builder4.OpenComponent<MudBlazor.MudCardContent>(23);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\n        ");
                        __builder4.OpenComponent<MudBlazor.MudCardActions>(25);
                        __builder4.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudButton>(27);
                            __builder5.AddAttribute(28, "Link", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
                               $"/catexdepto/{item.Id}"

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(29, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 25 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(30, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
                                                                                            Color.Tertiary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(31, "Class", "text-center");
                            __builder5.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(33, "Ver categorias");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 29 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
          }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\MINED\source\repos\ClienteBlazor.AccesoriosMoviles\ClienteBlazor.AccesoriosMoviles\Pages\CategoriasPage.razor"
        IEnumerable<Categoria> deptos = new List<Categoria>();
    protected override async Task OnInitializedAsync()
    {
        deptos = await CategoriaService.GetAll();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoriaService CategoriaService { get; set; }
    }
}
#pragma warning restore 1591
