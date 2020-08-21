using BlazingTasks.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingTasks.Client.Pages
{
    /// <summary>
    ///     Purpose:
    ///     Created By: Ron Jones
    ///     Created Date: 08/17/2020
    /// </summary>
    /// 
    public partial class TaskItemEdit
    {
        [Parameter] public int id { get; set; }
        private TaskItem taskItem { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            try
            {
                taskItem = await Http.GetFromJsonAsync<TaskItem>($"TaskItems/{id}");
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            };
        }

        private async Task HandleValidSubmit()
        {
            if (!taskItem.IsComplete)
            { taskItem.CompletedDate = DateTime.Today; }
            else
            { taskItem.CompletedDate = null; };

            var response = await Http.PutAsJsonAsync<TaskItem>($"TaskItems/{taskItem.TaskItemId}", taskItem);
            Navigation.NavigateTo("/");
        }
    }
}
