using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoMod7.Client.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        private IJSRuntime _js;

        public LocalStorageService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<T> GetItemAsync<T>(string key)
        {
            var json = await _js.InvokeAsync<string>("localStorage.getItem", key);
            return string.IsNullOrEmpty(json)
                ? default
                : JsonSerializer.Deserialize<T>(json);
        }

        public async Task SetItemAsync<T>(string key, T item)
        {
            await _js.InvokeVoidAsync("localStorage.setItem",
                key, JsonSerializer.Serialize(item));
        }
    }
}
