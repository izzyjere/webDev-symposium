namespace SampleApp.Models;

public class InvestigatingOfficer
{
	[Key]
	public int Id {get; set;}
	[Required]
	public string FirstName {get; set;}
	[Required]
	public string LastName {get; set;}
	[Required]
	public string Department {get; set;}
}
