using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MathRecognitionServiceIdentity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateOnly? DateOfBirth { get; set; }
        public bool IsDeleted { get; set; }
    }

}
