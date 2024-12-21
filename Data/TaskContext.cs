using Microsoft.EntityFrameworkCore;
using MVC_HW.Models;
namespace MVC_HW.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }
        
        public DbSet<Models.Task> Task { get; set; }
    }
}
