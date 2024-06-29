using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels;

public class AddJobViewModel
{
    [Required(ErrorMessage = "Job name is required.")]
    [StringLength(50, ErrorMessage = "Job name cannot be longer than 50 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Employer ID is required.")]
    public int EmployerId { get; set; }
    public List<SelectListItem>? Employers { get; set; }

    public AddJobViewModel() { }

    public AddJobViewModel(List<Employer> employerList)
    {
        Employers = new List<SelectListItem>();

        foreach (Employer employer in employerList)
        {
            Employers.Add(
                new SelectListItem 
                { 
                Value = employer.Id.ToString(), Text = employer.Name 
                });
        }
    }
}
