using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    }
}
