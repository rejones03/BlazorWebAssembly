using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BlazorLab2.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorLab2.Client.Shared
{
    public partial class QuickTask
    {
        [Parameter] public TaskItem TaskItem { get; set; }
        [Parameter] public EventCallback OnCancel { get; set; }
        [Parameter] public EventCallback OnSubmit { get; set; }
    }
}
