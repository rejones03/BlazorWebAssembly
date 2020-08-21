using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingTasks.ClassLibrary
{
    /// <summary>
    ///     Purpose:
    ///     Created By: Ron Jones
    ///     Created Date: 08/17/2020
    /// </summary>
    /// 
    public partial class MSHPDialog
    {
        [CascadingParameter(Name = "Color")] public string Style { get; set; }
        [Parameter] public RenderFragment Title { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public RenderFragment Buttons { get; set; }
    }
}
