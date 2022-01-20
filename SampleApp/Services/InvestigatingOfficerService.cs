namespace SampleApp.Services;
public class InvestigatingOfficerService
{
	readonly DatabaseContext database;
	public InvestigatingOfficerService(DatabaseContext _database)
	{
	    database = _database;
	}

	public bool Add(InvestigatingOfficer entity)
	{
            try
	    {    
		database.InvestigatingOfficers.Add(entity);
		database.SaveChanges();
		return true; 
	    }
	    catch 
	    {
		
		return false;
	    }
	}
	public bool Update(InvestigatingOfficer entity)
	{
            try
	    {    
		database.InvestigatingOfficers.Update(entity);
		database.SaveChanges();
		return true; 
	    }
	    catch 
	    {
		
		return false;
	    }
	}
	public bool Delete(InvestigatingOfficer entity)
	{
            try
	    {    
		database.InvestigatingOfficers.Remove(entity);
		database.SaveChanges();
		return true; 
	    }
	    catch 
	    {
		
		return false;
	    }
	}
	public InvestigatingOfficer Get(int id)
	{
	   return database.InvestigatingOfficers.FirstOrDefault(i=>i.Id == id);
	}
	public List<InvestigatingOfficer>GetAll()
	{
		return database.InvestigatingOfficers.ToList();
	}
    
}