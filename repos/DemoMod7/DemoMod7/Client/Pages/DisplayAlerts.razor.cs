using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMod7.Client.Pages
{
    /// <summary>
    ///     Purpose:
    ///     Created By: Ron Jones
    ///     Created Date: 08/17/2020
    /// </summary>
    /// 
    public partial class DisplayAlerts
    {
        protected async Task ShowAlertAsync()
        {
            await js.InvokeVoidAsync("mshpInterop.showAlert", "Fuck Off, Planet!");
        }
    }
}
