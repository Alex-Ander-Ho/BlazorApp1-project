using BlazorApp1.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class AppDBContext : DbContext
	{
		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teather> Teathers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
		{
			base.OnConfiguring(optionsbuilder);
			optionsbuilder.UseLazyLoadingProxies();
		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	modelBuilder.Entity<Students>()
		//		.HasOne(s => s.Teather)
		//		.WithMany(c => c.Students)
		//		.HasForeignKey(s => s.TeatherId);
		//}
	}
}
