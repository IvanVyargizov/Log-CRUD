using SQLite.CodeFirst;
using System;
using System.Data.Entity;

namespace AppWinFormCRUD.Data
{
    public class MyDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteMigrationInitializer = new MigrateDatabaseToLatestVersion<MyDbContext, Migrations.Configuration>(true);
            Database.SetInitializer(sqliteMigrationInitializer);

            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<DbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

        public DbSet<Tables.Person> Persons { get; set; }
        public DbSet<Tables.Car> Cars { get; set; }
        public DbSet<Tables.Crew> Crews { get; set; }
    }
}
