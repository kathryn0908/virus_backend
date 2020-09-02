using Microsoft.EntityFrameworkCore;
using virus_mvc.Models;

namespace virus_mvc.Data
{
    public class virus_mvcContext : DbContext
    {
        public virus_mvcContext (DbContextOptions<virus_mvcContext> options)
            : base(options)
        {
        }

        public DbSet<VirusData> VirusData { get; set; }

        // public bool TableExists(int id)
        // {
        //     try
        //     {
        //         context.VirusData.Where(s => s.Id == id).Count();
        //         return true;
        //     }
        //     catch 
        //     {
        //         return false;
        //     }
        // }
    }
}