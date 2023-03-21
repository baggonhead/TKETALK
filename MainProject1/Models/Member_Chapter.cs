namespace MainProject1.Models
{
    public class Member_Chapter
    {
        public int ChapterId { get; set; }
        public Chapters chapter { get; set; }
        public Members member { get; set; }
        public int MemberId { get; set; }

    }
}
