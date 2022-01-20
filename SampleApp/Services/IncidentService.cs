namespace SampleApp.Services;
public class IncidentService
{
	readonly DatabaseContext database;
	public IncidentService(DatabaseContext _database)
	{
	    database = _database;
	}

	public bool Add(Incident entity)
	{
            try
	    {    
		database.Incidents.Add(entity);
		database.SaveChanges();
		return true; 
	    }
	    catch 
	    {
		
		return false;
	    }
	}
	public bool Update(Incident entity)
	{
            try
	    {    
		database.Incidents.Update(entity);
		database.SaveChanges();
		return true; 
	    }
	    catch 
	    {
		
		return false;
	    }
	}
	public bool Delete(Incident entity)
	{
            try
	    {    
		database.Incidents.Remove(entity);
		database.SaveChanges();
		return true; 
	    }
	    catch 
	    {
		
		return false;
	    }
	}
	public Incident Get(int id)
	{
	    return database.Incidents.FirstOrDefault(i=>i.Id == id);
	}
	public List<Incident>GetAll()
	{
		return database.Incidents.ToList();
	}
    
}