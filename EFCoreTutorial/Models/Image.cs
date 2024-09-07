namespace EFCoreTutorial.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Url { get; set; }
        public ICollection<Blog> Blogs { get; set;}
    }
}
