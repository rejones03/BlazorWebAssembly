using BlazingTasks.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingTasks.Client.Pages.Admin
{
    /// <summary>
    ///     Purpose:
    ///     Created By: Ron Jones
    ///     Created Date: 08/17/2020
    /// </summary>
    /// 
    public partial class TagEdit
    {
        [Parameter] public int id { get; set; }
        private Tag tag { get; set; }
        protected override async Task OnParametersSetAsync()
        {
            if (id == 0)
            {
                tag = new Tag();
            }
            else
            {
                try
                {
                    tag = await Http.GetFromJsonAsync<Tag>($"Tags/{id}");
                }
                catch (AccessTokenNotAvailableException exception)
                {
                    exception.Redirect();
                };
            };
        }
        private async Task HandleValidSubmit()
        {
            if (id == 0)
            {
                // Add the tag
                var response = await Http.PostAsJsonAsync<Tag>("Tags", tag);
            }
            else
            {
                // Update the tag
                var response = await Http.PutAsJsonAsync<Tag>($"Tags/{tag.TagId}", tag);
            };
            Navigation.NavigateTo("/Admin/TagListing");
        }
    }
}
