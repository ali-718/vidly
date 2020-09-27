using System.Data.Entity;


namespace Vidly.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Test> Test { get; set; }
        public MyDbContext()
        {

        }
    }
}