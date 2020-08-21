#pragma checksum "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d147b6cb504f74aef4507650b9e5f94278d8975d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingTasks.Client.Shared
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
    public partial class QuickTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
       
    [Parameter] public TaskItem TaskItem { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }
    [Parameter] public EventCallback OnSubmit { get; set; }

    private IList<Tag> tags;
    protected async override Task OnInitializedAsync()
    {
        tags = await HttpClient.GetFromJsonAsync<List<Tag>>("Tags");
    }

    void TagSelected(ChangeEventArgs e)
    {
        if (int.TryParse((string)e.Value, out var index) && index >= 0)
        {
            AddTag(tags[index]);
        }
    }

    void AddTag(Tag tag)
    {
        if (TaskItem.Tags.Find(pt => pt.Tag == tag) == null)
        {
            TaskItem.Tags.Add(new TaskTag() { Tag = tag });
        };
    }

    void RemoveTag(Tag tag)
    {
        TaskItem.Tags.RemoveAll(tt => tt.Tag == tag);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591