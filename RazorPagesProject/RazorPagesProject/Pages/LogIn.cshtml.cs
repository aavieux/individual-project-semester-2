using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Security.Claims;
using RazorPagesProject.Models;
using ClassLibrary.Controllers;
using RazorPagesProject.Helpers;

namespace RazorPagesProject.Pages
{
    public class LogInModel : PageModel
    {
        private readonly IConfiguration configuration;

        private const string RememberMeCookiename = "RememberMe";

        [BindProperty]
        public CredentialsViewModel Credentials { get; set; }
        
        public LogInModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult OnGet()
        {
            #region handle rememberme cookie
            if (Request.Cookies.ContainsKey(RememberMeCookiename))
            {
                this.Credentials = new Models.CredentialsViewModel();
                this.Credentials.Email = Request.Cookies[RememberMeCookiename];
                this.Credentials.RememberMe = true; 
            }
            #endregion

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                #region handle rememberme cookie
                if (this.Credentials.RememberMe)
                {
                    CookieOptions cookieOptions = new CookieOptions();
                    cookieOptions.Expires = DateTime.Now.AddDays(4);
                    Response.Cookies.Append(RememberMeCookiename, this.Credentials.Email, cookieOptions);
                }
                else
                {
                    if (Request.Cookies.ContainsKey(RememberMeCookiename))
                    {
                        Response.Cookies.Delete(RememberMeCookiename);
                    }
                }
                #endregion

                List<Claim> claims = new IdentityManager().Authenticate(this.Credentials.MapToDomain());
                if (claims.Count > 0)
                {
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                    return new RedirectToPageResult("Index");
                }
                else
                {
                    ViewData["ErrorMessage"] = "Unable to login.";
                    return Page();
                }
            }
            return Page();
        }
    }
}
