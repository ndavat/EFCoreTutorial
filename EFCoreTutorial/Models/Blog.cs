using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTutorial.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
