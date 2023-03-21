using MainProject1.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MainProject1.Models
{
    public class Colleges
    {
        [Key] 
        public int Id { get; set; }
        public string name{ get; set; }
        public string description { get; set; }
        public string address { get; set; }
        public ChapterCategory ChapterCategory { get; set; }
        public List<Chapters> Chapter { get; set; }
    }
}
