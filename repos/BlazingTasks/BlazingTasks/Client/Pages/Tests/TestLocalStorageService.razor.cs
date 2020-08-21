using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazingTasks.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly;

using BlazingTasks.Client.Services;
using Microsoft.JSInterop;

namespace BlazingTasks.Client.Pages.Tests
{
    /// <summary>
    ///     Purpose:
    ///     Created By: Ron Jones
    ///     Created Date: 08/17/2020
    /// </summary>
    /// 
    public partial class TestLocalStorageService
    {
        private IList<Tag> tagsFromLocalStorage = new List<Tag>();
        private bool IsActive { get; set; }
        private int Count { get; set; } = 0;

        private async Task SaveTags()
        {
            try
            {
                IList<Tag> tagsToSave;
                tagsToSave = await Http.GetFromJsonAsync<IList<Tag>>("Tags");
                LocalStorageService ls = new LocalStorageService(js);
                await ls.SetItemAsync("tags", tagsToSave);
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }

        private async Task GetTags()
        {
            LocalStorageService ls = new LocalStorageService(js);
            tagsFromLocalStorage = await ls.GetItemAsync<IList<Tag>>("tags");
        }

        private void Button_Click()
        {
            IsActive = !IsActive;
            IncrementCount();
        }

        [JSInvokable]
        private async Task IncrementCount()
        {
            if (IsActive)
            {
                Count++;
                StateHasChanged();
                await js.InvokeVoidAsync("mshpInterop.callDotNetCounter");
            }
        }
    }
}
