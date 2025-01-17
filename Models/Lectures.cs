namespace Demo.Models
{
    public class Lectures
    {
        public int Course_ID { get; set; }
        public List<string> LectureLinks { get; set; } = new List<string>();
    }
}
