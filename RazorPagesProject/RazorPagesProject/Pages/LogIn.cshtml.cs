using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace RazorPagesProject.Pages
{
    public class LogInModel : PageModel
    {
        private readonly IConfiguration configuration;
        public LogInModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void OnGet()
        {
        }
    }
}
