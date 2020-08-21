using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingTasks.Server.Data;
using BlazingTasks.Shared;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace BlazingTasks.Server.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TaskItemsController(ApplicationDbContext context)
        {
            _context = context;
        }
        private Guid GetUserId()
        {
            string user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return new Guid(user); ;
        }

        // GET: api/TaskItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskItem>>> GetTaskItem()
        {
            List<TaskItem> tasks = await _context.TaskItem
                .Where(q => q.UserId == GetUserId())
                .Include(t => t.Tags).ThenInclude(p => p.Tag)
                .OrderBy(o => o.TaskItemId)
                .ToListAsync();

            return tasks.ToList();
        }

        // GET: api/TaskItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskItem>> GetTaskItem(int id)
        {
            var taskItem = await _context.TaskItem
                .Where(q => q.TaskItemId == id)
                .Where(q => q.UserId == GetUserId())
                .OrderBy(o => o.TaskItemId)
                .SingleOrDefaultAsync();

            if (taskItem == null)
            {
                return NotFound();
            }

            return taskItem;
        }

        // PUT: api/TaskItems/5
         [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskItem(int id, TaskItem taskItem)
        {
            if (id != taskItem.TaskItemId)
            {
                return BadRequest();
            }

            taskItem.UserId = GetUserId();

            _context.Entry(taskItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TaskItems
        [HttpPost]
        public async Task<ActionResult<TaskItem>> PostTaskItem(TaskItem taskItem)
        {
            taskItem.UserId = GetUserId();
            taskItem.DueDate = DateTime.Now.Date;

            _context.TaskItem.Attach(taskItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaskItem", new { id = taskItem.TaskItemId }, taskItem);
        }

        // DELETE: api/TaskItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TaskItem>> DeleteTaskItem(int id)
        {
            var taskItem = await _context.TaskItem
               .Where(q => q.TaskItemId == id)
               .Where(q => q.UserId == GetUserId())
               .OrderBy(o => o.TaskItemId)
               .SingleOrDefaultAsync();

            if (taskItem == null)
            {
                return NotFound();
            }

            _context.TaskItem.Remove(taskItem);
            await _context.SaveChangesAsync();

            return taskItem;
        }

        private bool TaskItemExists(int id)
        {
            return _context.TaskItem.Any(e => e.TaskItemId == id);
        }
    }
}
