using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnitOfWork.Model;

namespace UnitOfWork.DAL
{
    public class PlutoContext : DbContext
    {
        public PlutoContext() : base("name=PlutoConnString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new PlutoInitializer());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<PlutoContext>());
            base.OnModelCreating(modelBuilder);
        }
    }

    class PlutoInitializer : DropCreateDatabaseIfModelChanges<PlutoContext>
    {
        protected override void Seed(PlutoContext context)
        {
            base.Seed(context);
        }
    }
}
