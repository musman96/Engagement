using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchardCore.IncidentReports.ViewModels;
public class IncidentReportViewModel
{
    public  MyProperty { get; set; }
    public string? IncidentNo { get; set; }
    public DateTime IncidentDate { get; set; }
    public string? Type { get; set; }
    public string? TypeDescription { get; set; }
    public string? Department { get; set; }
    public string? NameofPersonInvolved { get; set; }
    public string? Occupation { get; set; }
    public string? WorkLocation { get; set; }
    public string? InjuredPart { get; set; }
    public string? InjuryType { get; set; }
    public string? FatalDescription { get; set; }
    public string? FirstAidDetails { get; set; }
    public string? FactsBehindIncident { get; set; }
    public string? RooCause { get; set; }
    public string? CorrectiveAction { get; set; }
    public string? ReportedBy { get; set; }
    public DateTime ReportedDate { get; set; }

}
