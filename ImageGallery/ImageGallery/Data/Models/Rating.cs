using Microsoft.Extensions.Configuration.UserSecrets;

namespace DiplomentProekt.Data.Models
{
    public class Rating: BaseEntity<int>
    {
        public string UserID {  get; set; }
        public virtual AppUser User { get; set; }
        public string PictureId { get; set; }
        public virtual Picture Picture { get; set; }
        public RatingsEnum Ratings { get; set; }

    }
}
