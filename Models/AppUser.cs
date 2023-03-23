using Microsoft.AspNetCore.Identity;

namespace SecondProject.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Gender { get; set;}
        public string Phone { get; set;}

    }
}
