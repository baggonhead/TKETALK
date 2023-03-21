using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainProject1.Models
{
    public class Chapters
    {
        [Key]
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string description { get; set; }
        public List<Member_Chapter> Member_Chapters { get; set; }
        
        public int CollegesID { get; set; }
        [ForeignKey("CollegesID")]
        public Colleges Colleges { get; set; }

        public int leadersId { get; set; }
        [ForeignKey("leadersId")]
        public Leaders Leaders { get; set; }    


    }
}
