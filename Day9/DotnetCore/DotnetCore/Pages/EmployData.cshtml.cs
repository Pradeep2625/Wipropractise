using DotnetCore.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace DotnetCore.Pages.Shared
{
    public class EmployDataModel : PageModel
    {
       public List<Employ> employData { get; set; }
        
        public void OnGet()
        {
            employData = new List<Employ>
            {
                new Employ("John Doe", "E001", "Software Engineer"),
                new Employ("Jane Smith", "E002", "Project Manager"),
                new Employ("Sam Brown", "E003", "UX Designer")
            };

        }
    }
}
