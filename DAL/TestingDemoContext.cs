using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TestingDemo.DAL.Models;

namespace TestingDemo.DAL
{
    public class TestingDemoContext : DbContext
    {
        public TestingDemoContext() : base("TestingDemoConnectionString")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}