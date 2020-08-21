using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingTasks.Client.Pages.Tests
{
    public class CallDotNet
    {
        [Inject] public IJSRuntime js { get; set; }
        [JSInvokable("GetGuid")]
        public static string GenerateGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
