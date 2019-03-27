using MyPlan.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyPlan.DAL
{
    public class Context : DbContext
    {

        public Context() : base("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Danil\\source\\repos\\MyPlan\\MyPlan\\App_Data\\MyPlan.mdf;Integrated Security=True")
        {
        }

        public DbSet<Note>    Notes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Number>  Numbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
            catch
            {
            }
        }
    }
}