using First_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_Project.DAL;

public class ProjectDBContext:DbContext
{
	public ProjectDBContext()
	{

	}

    public ProjectDBContext(DbContextOptions<ProjectDBContext> dbContextOptions):base(dbContextOptions)
    {
        
    }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = ProjectDB");
	}

	public DbSet<Customers> Customer { get; set; }
	public DbSet<Tours> Tour { get; set; }
	public DbSet<Bookings> Booking { get; set; }
	public DbSet<Payments> Payment { get; set; }


}
