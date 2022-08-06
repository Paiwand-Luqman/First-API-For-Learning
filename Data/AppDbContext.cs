
namespace FirstAPI.Data
{
    public class AppDbContext : DbContext //this needs the EntityFrameworkCore that i added in the GlobalUsing
    {
        /// <summary>
        /// i think this declares this file as a bridge between the app and the sql database
        /// </summary
        //public AppDbContext(DbContextOptions<DbContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("connection");
            optionsBuilder.UseSqlServer(connectionString);
        }


        /// <summary>
        /// Define table names for the C# tables so now we can use the name Books to get and send data to the database
        /// </summary>
        public DbSet<Book> Books { get; set; }
    }
}
