#pragma checksum "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92fb83ed07a8f5cb12c7f0cc6a8ed25f80dbc946"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingTasks.Client.Pages
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
#line 2 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/taskedit/{id:int}")]
    public partial class TaskItemEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Task</h2>\r\n");
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
 if (taskItem == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                     taskItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "label");
                __builder2.AddMarkupContent(16, "\r\n                Name\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                        taskItem.TaskName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taskItem.TaskName = __value, taskItem.TaskName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => taskItem.TaskName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __Blazor.BlazingTasks.Client.Pages.TaskItemEdit.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                          () => taskItem.TaskName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "label");
                __builder2.AddMarkupContent(31, "\r\n                Due Date\r\n                ");
                __Blazor.BlazingTasks.Client.Pages.TaskItemEdit.TypeInference.CreateInputDate_1(__builder2, 32, 33, "form-control", 34, 
#nullable restore
#line 28 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                        taskItem.DueDate

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taskItem.DueDate = __value, taskItem.DueDate)), 36, () => taskItem.DueDate);
                __builder2.AddMarkupContent(37, "\r\n                ");
                __Blazor.BlazingTasks.Client.Pages.TaskItemEdit.TypeInference.CreateValidationMessage_2(__builder2, 38, 39, 
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                          () => taskItem.DueDate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "label");
                __builder2.AddMarkupContent(46, "\r\n                Priority\r\n                ");
                __Blazor.BlazingTasks.Client.Pages.TaskItemEdit.TypeInference.CreateInputSelect_3(__builder2, 47, 48, "form-control", 49, "width:200px", 50, 
#nullable restore
#line 35 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                         taskItem.Priority

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taskItem.Priority = __value, taskItem.Priority)), 52, () => taskItem.Priority, 53, (__builder3) => {
                    __builder3.AddMarkupContent(54, "\r\n                    ");
                    __builder3.AddMarkupContent(55, "<option>Low</option>\r\n                    ");
                    __builder3.AddMarkupContent(56, "<option>Medium</option>\r\n                    ");
                    __builder3.AddMarkupContent(57, "<option>High</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(58, "\r\n                ");
                __Blazor.BlazingTasks.Client.Pages.TaskItemEdit.TypeInference.CreateValidationMessage_4(__builder2, 59, 60, 
#nullable restore
#line 40 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                          () => taskItem.Priority

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenElement(66, "label");
                __builder2.AddMarkupContent(67, "\r\n                Hours\r\n                ");
                __Blazor.BlazingTasks.Client.Pages.TaskItemEdit.TypeInference.CreateInputNumber_5(__builder2, 68, 69, "form-control", 70, 
#nullable restore
#line 46 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                          taskItem.Hours

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taskItem.Hours = __value, taskItem.Hours)), 72, () => taskItem.Hours);
                __builder2.AddMarkupContent(73, "\r\n                ");
                __Blazor.BlazingTasks.Client.Pages.TaskItemEdit.TypeInference.CreateValidationMessage_6(__builder2, 74, 75, 
#nullable restore
#line 47 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                          () => taskItem.Hours

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "label");
                __builder2.AddMarkupContent(82, "\r\n                Notes\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(83);
                __builder2.AddAttribute(84, "class", "form-control");
                __builder2.AddAttribute(85, "style", "width:200px");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                            taskItem.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taskItem.Notes = __value, taskItem.Notes))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => taskItem.Notes));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n                ");
                __Blazor.BlazingTasks.Client.Pages.TaskItemEdit.TypeInference.CreateValidationMessage_7(__builder2, 90, 91, 
#nullable restore
#line 54 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                          () => taskItem.Notes

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "label");
                __builder2.AddMarkupContent(98, "\r\n                Is Complete?\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(99);
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
                                            taskItem.IsComplete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taskItem.IsComplete = __value, taskItem.IsComplete))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => taskItem.IsComplete));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.AddMarkupContent(106, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 65 "C:\Users\Administrator\source\repos\BlazingTasks\BlazingTasks\Client\Pages\TaskItemEdit.razor"
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
namespace __Blazor.BlazingTasks.Client.Pages.TaskItemEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
