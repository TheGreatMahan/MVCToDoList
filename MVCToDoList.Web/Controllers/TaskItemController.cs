using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MVCToDoList.Web.Data;
using MVCToDoList.Web.Models;
using MVCToDoList.Web.Models.Entities;

namespace MVCToDoList.Web.Controllers
{
    public class TaskItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskItemController(ApplicationDbContext dbContext)
        {
            this._context = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddTaskItemViewModel viewModel)
        {
            var Task = new TaskItem
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                IsCompleted = viewModel.IsCompleted,
                DueDate = viewModel.DueDate,
            };

            await _context.TaskItems.AddAsync(Task);
            _context.SaveChanges();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListAll()
        {
            var tasks = await _context.TaskItems.Where(item => item.IsCompleted == false).ToListAsync();
            return View(tasks);
        }

        [HttpGet]
        public async Task<IActionResult> ListCompletedTasks()
        {
            var incompleteTasks = await _context.TaskItems.Where(item => item.IsCompleted != false).ToListAsync();
            return View(incompleteTasks);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var task = await _context.TaskItems.FindAsync(id);

            return View(task);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TaskItem viewModel)
        {
            var task = await _context.TaskItems.FindAsync(viewModel.Id);

            if(task != null)
            {
                task.Title = viewModel.Title;
                task.Description = viewModel.Description;
                task.IsCompleted = viewModel.IsCompleted;
                task.DueDate = viewModel.DueDate;

                await _context.SaveChangesAsync();
            }

            return RedirectToAction("ListAll", "TaskItem");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var task = await _context.TaskItems.FindAsync(id);

            if (task != null)
            {
                _context.TaskItems.Remove(task);

                await _context.SaveChangesAsync();
            }

            return Redirect("ListCompletedTasks");
        }

        [HttpGet]
        public async Task<IActionResult> Complete(Guid id)
        {
            var task = await _context.TaskItems.FindAsync(id);

            if (task != null)
            {
                task.IsCompleted = true;
                await _context.SaveChangesAsync();
            }

            return Redirect("ListAll");
        }
    }
}
