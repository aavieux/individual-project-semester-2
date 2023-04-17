using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Text.Json;
using System.Text;
using ClassLibrary.Controllers;

namespace RazorPagesProject.Pages
{
    public class IndexModel : PageModel
    {
        internal StatisticsManager statisticsManager;
        public IndexModel()
        {
            this.statisticsManager = new StatisticsManager();
        }
        public void OnGet()
        {
            
        }
    }
}