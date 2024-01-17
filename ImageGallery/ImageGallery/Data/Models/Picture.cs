namespace DiplomentProekt.Data.Models
{
    public class Picture:BaseEntity<string>
    {
        public Picture() {
        this.Ratings = new HashSet<Rating>();
        }    
       public string Extention { get; set; }  
        public virtual ICollection<Rating> Ratings { get; set; }  
    }
}
