using kıvıl.Entities;
using Microsoft.EntityFrameworkCore;

namespace kıvıl.Context
{
	public class AppDbContext:DbContext
	{
		public DbSet<Hasta> Hastalar { get; set;  }
		public DbSet<Test> Testler { get; set; }

		public AppDbContext()
        {
            
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=HastaneDb;Trusted_Connection=True;TrustServerCertificate=true;");


		}

	}
}
