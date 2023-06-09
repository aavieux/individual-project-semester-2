using ClassLibrary.Controllers;
using RazorPagesProject.Models;

namespace RazorPagesProject.Helpers
{
    public static class CreadentialsMapper
    {
        public static Credentials MapToDomain(this CredentialsViewModel model)
        { 
            return new Credentials(model.Email, model.Password);
        }
    }
}
