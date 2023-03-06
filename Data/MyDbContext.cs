using SQLite.CodeFirst;
using System.Data.Entity;

namespace AppWinFormCRUD.Data
{
    public class MyDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<DbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            //var model = modelBuilder.Build(Database.Connection);
            //ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
            //_ = sqlGenerator.Generate(model.StoreModel);

            //modelBuilder.Entity<Tables.Crew>()
            //    .HasRequired<Tables.User>(c => c.User)
            //    .WithOptional(u => u.Crew);

            //modelBuilder.Entity<Tables.Crew>()
            //    .HasRequired<Tables.Car>(c => c.Car)
            //    .WithOptional(cr => cr.Crew);

        }

        public DbSet<Tables.Person> Persons { get; set; }
        public DbSet<Tables.Car> Cars { get; set; }
        public DbSet<Tables.Crew> Crews { get; set; }
    }
}
