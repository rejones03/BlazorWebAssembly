#pragma checksum "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7387e7b14e9ed262ef51de6135528db1519ececc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingTasks.Client.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using BlazingTasks.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using BlazingTasks.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using BlazingTasks.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\_Imports.razor"
using BlazingTasks.ClassLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/taglisting")]
    public partial class TagListing : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"p-2\">Tag Listing</h2>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary mb-4");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
                                               AddTag

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Add Tag");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
 if (tags == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
}
else if (tags.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.AddMarkupContent(9, "<div>Please use the <strong>Add Tag</strong> button to add some tags.</div>\r\n");
#nullable restore
#line 17 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __Blazor.BlazingTasks.Client.Pages.Admin.TagListing.TypeInference.CreateItemDisplay_0(__builder, 11, 12, 
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
                        tags

#line default
#line hidden
#nullable disable
            , 13, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
                                          (tag)=>DeleteTag((Tag)tag)

#line default
#line hidden
#nullable disable
            ), 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
                           (tag)=>EditTag((Tag)tag)

#line default
#line hidden
#nullable disable
            ), 15, (tag) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddContent(17, 
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
             tag.TagName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\Admin\TagListing.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlazingTasks.Client.Pages.Admin.TagListing
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateItemDisplay_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IList<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg3)
        {
        __builder.OpenComponent<global::BlazingTasks.Client.Shared.ItemDisplay<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "OnDelete", __arg1);
        __builder.AddAttribute(__seq2, "OnEdit", __arg2);
        __builder.AddAttribute(__seq3, "ItemTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
