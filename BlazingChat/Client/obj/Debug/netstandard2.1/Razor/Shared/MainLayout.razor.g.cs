#pragma checksum "C:\Data\CuriousDrive\BlazingChat\BlazingChat\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "551fcdfb2d1c4cfda65e53b64cd111c9bb52f20a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingChat.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\BlazingChat\BlazingChat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BlazingChat\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BlazingChat\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BlazingChat\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\BlazingChat\BlazingChat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\BlazingChat\BlazingChat\Client\_Imports.razor"
using BlazingChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\BlazingChat\BlazingChat\Client\_Imports.razor"
using BlazingChat.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content px-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddContent(6, 
#nullable restore
#line 13 "C:\Data\CuriousDrive\BlazingChat\BlazingChat\Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591