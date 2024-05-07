using Microsoft.EntityFrameworkCore;

namespace weebapp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>option):base(option)
        {
            
        }
    }
}
