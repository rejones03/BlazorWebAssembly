#pragma checksum "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d147b6cb504f74aef4507650b9e5f94278d8975d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<BlazingTasks.ClassLibrary.MSHPDialog>(0);
            __builder.AddAttribute(1, "Title", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<div>Add Task</div>\r\n    ");
            }
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.AddMarkupContent(8, "<label>\r\n                Task:\r\n            </label>\r\n            ");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                                      TaskItem.TaskName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskItem.TaskName = __value, TaskItem.TaskName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, "<label>Tags:</label>\r\n");
#nullable restore
#line 16 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
             if (tags == null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(18, "                ");
                __builder2.OpenElement(19, "select");
                __builder2.AddAttribute(20, "class", "custom-select");
                __builder2.AddAttribute(21, "disabled", true);
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.OpenElement(23, "option");
                __builder2.AddContent(24, "(loading...)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(27, "                ");
                __builder2.OpenElement(28, "select");
                __builder2.AddAttribute(29, "class", "custom-select");
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                                                         TagSelected

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "option");
                __builder2.AddAttribute(33, "value", "-1");
                __builder2.AddAttribute(34, "disabled", true);
                __builder2.AddAttribute(35, "selected", true);
                __builder2.AddContent(36, "(select)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n");
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                     for (var i = 0; i < tags.Count; i++)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(38, "                        ");
                __builder2.OpenElement(39, "option");
                __builder2.AddAttribute(40, "value", 
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                                        i

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(41, 
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                                            tags[i].TagName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n");
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(43, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n");
#nullable restore
#line 31 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(45, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "tags");
                __builder2.AddMarkupContent(49, "\r\n");
#nullable restore
#line 34 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
             foreach (var tag in TaskItem.Tags)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(50, "                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "tag" + " tag-" + (
#nullable restore
#line 36 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                                     tag.Tag.TagColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.SetKey(
#nullable restore
#line 36 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                                                             tag

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.AddContent(54, 
#nullable restore
#line 37 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                     tag.Tag.TagName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "button");
                __builder2.AddAttribute(57, "type", "button");
                __builder2.AddAttribute(58, "class", "delete-tags");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                                                                          () => RemoveTag(tag.Tag)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(60, "x");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n");
#nullable restore
#line 40 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(63, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n    ");
            }
            ));
            __builder.AddAttribute(65, "Buttons", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenElement(67, "button");
                __builder2.AddAttribute(68, "class", "btn btn-secondary mr-auto");
                __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                                                            OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(70, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "button");
                __builder2.AddAttribute(73, "class", "btn btn-success ml-auto");
                __builder2.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Shared\QuickTask.razor"
                                                          OnSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(75, "Submit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
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
