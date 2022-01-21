global using System.ComponentModel.DataAnnotations;
namespace SampleApp.Models;
public class Incident
{
        [Key]
	public int Id {get; set;}
	public int InvestigatingOfficerId {get; set; }
        public DateTime IncidentDate {get; set; } 
	[Required]
        public string IncidentCategory { get; set; }
	[Required]
	public string Status {get; set;}
	[Required]
	public string IncidentLocation {get; set;}
	[Required]
	public string InvestigationFindings {get; set;}
	[Required]
	public string Resolution {get; set;}
	public DateTime DateClosed {get; set;}
	public InvestigatingOfficer InvestigatingOfficer { get; set; }

}
