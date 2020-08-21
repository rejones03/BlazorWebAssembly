using BlazingTasks.Shared;
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
    public partial class TagListing
    {
        private IList<Tag> tags;
        protected override async Task OnInitializedAsync()
        {
            try
            {
                tags = await Http.GetFromJsonAsync<IList<Tag>>("Tags");
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            };
        }
        private void AddTag()
        {
            Navigation.NavigateTo("/admin/tagedit/0");
        }
        private async Task DeleteTag(Tag tag)
        {
            tags.Remove(tag);
            await Http.DeleteAsync($"Tags/{tag.TagId}");
        }
        private void EditTag(Tag tag)
        {
            Navigation.NavigateTo($"/admin/tagedit/{tag.TagId}");
        }
    }
}
