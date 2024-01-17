using Microsoft.AspNetCore.Identity;

namespace DiplomentProekt.Data.Models
{
    public class AppUser : IdentityUser<string>
    {
        public AppUser()
        {
            this.Ratings = new HashSet<Rating>();
            this.Gallerys = new HashSet<Gallery>(); 
        }
        public string ProfilePicture {  get; set; }
       public ICollection<Rating> Ratings { get; set; }
       public ICollection<Gallery> Gallerys { get; set; }
    }
}
