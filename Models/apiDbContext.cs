using Microsoft.EntityFrameworkCore;

namespace web_api_dot_net.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<User> users { get; set; }
    }
}
