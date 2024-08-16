using Microsoft.EntityFrameworkCore;

namespace weTasks.Data
{
    public class SystemTasksDBContext : DbContext
    {
        public SystemTasksDBContext(DbContextOptions<SystemTasksDBContext> options) : base(options)
        {
            
        }
        public DbSet<Models.UserModel> Users { get; set; }
        public DbSet<Models.TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Map.UserMap());
            modelBuilder.ApplyConfiguration(new Map.TaskMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
