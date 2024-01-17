namespace DiplomentProekt.Data.Models
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFavorite { get; set; }
    }
}
