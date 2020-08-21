using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DemoMod7.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly;

using DemoMod7.Client.Services;

namespace DemoMod7.Client.Pages.Tests
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
        private async Task SaveTags()
        {
            try
            {
                IList<Tag> tagsToSave;
                tagsToSave = await Http.GetFromJsonAsync<IList<Tag>>("Tags");
                LocalStorageService ls =
                new Services.LocalStorageService(js);
                await ls.SetItemAsync("tags", tagsToSave);
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }
        private async Task GetTags()
        {
            LocalStorageService ls =
            new Services.LocalStorageService(js);
            tagsFromLocalStorage = await ls.GetItemAsync<IList<Tag>>("tags");
        }
    }
}
