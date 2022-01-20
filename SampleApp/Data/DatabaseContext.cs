
namespace SampleApp.Data;

public class DatabaseContext : DbContext
{
	public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
	{
	    
	}
	public DbSet<Incident> Incidents {get; set;}
	public DbSet<InvestigatingOfficer> InvestigatingOfficers {get; set;}
}
