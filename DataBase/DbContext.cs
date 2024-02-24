using TaskManager.DataBase.Models;

namespace TaskManager.DataBase
{
    public class DbContext : DbContext
    {
        public DbSet<UserEntity> user { get; set; }
    }
}
