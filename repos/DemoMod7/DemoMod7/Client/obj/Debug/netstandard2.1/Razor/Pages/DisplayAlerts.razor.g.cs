#pragma checksum "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\Pages\DisplayAlerts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bd8f5b4303f7db1e341e84013f360e124654e08"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoMod7.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\_Imports.razor"
using DemoMod7.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\_Imports.razor"
using DemoMod7.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/showAlert")]
    public partial class DisplayAlerts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Invoke Javascript</h2>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Show Alert</h3>\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\DemoMod7\DemoMod7\Client\Pages\DisplayAlerts.razor"
                                          ShowAlertAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Show Alert");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
