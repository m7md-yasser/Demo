namespace Demo.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Doctor_ID { get; set; }
        public int Student_ID { get; set; }
        public string doc_Name { get; internal set; }
    }
}
