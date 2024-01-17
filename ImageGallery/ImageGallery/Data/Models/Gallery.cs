namespace DiplomentProekt.Data.Models
{
    public class Gallery : BaseEntity<int>
    {
        public string Descripition { get; set; }
        public bool IsPrivate { get; set; }

            
    }
}
