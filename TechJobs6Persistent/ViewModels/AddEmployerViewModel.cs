using System.ComponentModel.DataAnnotations;
// in order to use validation attributes

namespace TechJobs6Persistent.ViewModels;

public class AddEmployerViewModel
{
    [Required(ErrorMessage = "Employer name is required.")]
    [StringLength(50, ErrorMessage = "Employer name cannot be longer than 50 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage ="Location name is required.")]
    [StringLength(100, ErrorMessage = "Location name cannot be longer than 100 characters.")]
    public string? Location { get; set; }

}
