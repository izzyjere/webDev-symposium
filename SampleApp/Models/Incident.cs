global using System.ComponentModel.DataAnnotations;
namespace SampleApp.Models;


public class Incident
{
        [Key]
	public int Id {get; set;}
	public int InvestigatingOfficerId {get; set; }
        public DateTime IncidentDate {get; set; } 
        public string IncidentCategory { get; set; }
	public string Status {get; set;}
	public string IncidentLocation {get; set;}
	public string InvestigationFindings {get; set;}
	public string Resolution {get; set;}
	public DateTime DateClosed {get; set;}
	public InvestigatingOfficer InvestigatingOfficer { get; set; }

	

}
