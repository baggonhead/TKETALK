using System.ComponentModel.DataAnnotations;

namespace MainProject1.Models
{
    public class Leaders
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public List<Chapters> Chapter { get; set; }

    }
}
