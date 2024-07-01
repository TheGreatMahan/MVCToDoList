using Microsoft.EntityFrameworkCore;
using MVCToDoList.Web.Models.Entities;

namespace MVCToDoList.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
