using BlazorLab2.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorLab2.Client.Pages
{
    public partial class MyTasks
    {
        [Inject] HttpClient Http { get; set; }
        private IList<TaskItem> tasks;
        private bool showingQuickTask = false;
        private TaskItem newTask;
        protected override async Task OnInitializedAsync()
        {
            tasks = await Http.GetFromJsonAsync<IList<TaskItem>>("TaskItems");
        }
        void AddTask()
        {
            newTask = new TaskItem();
            showingQuickTask = true;
        }
        private async Task SubmitTask()
        {
            if (!string.IsNullOrWhiteSpace(newTask.TaskName))
            {
                tasks.Add(new TaskItem { TaskName = newTask.TaskName });
                showingQuickTask = false;
                await Http.PostAsJsonAsync<TaskItem>("TaskItems", newTask);
            }
        }
        private async Task CheckboxChecked(TaskItem task)
        {
            task.IsComplete = !task.IsComplete;
            string requestUri = $"TaskItems/{task.TaskItemId}";
            await Http.PutAsJsonAsync<TaskItem>(requestUri, task);
        }
        private async Task DeleteTask(TaskItem taskItem)
        {
            tasks.Remove(taskItem);
            await Http.DeleteAsync($"TaskItems/{taskItem.TaskItemId}");
        }

    }
}
