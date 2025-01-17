namespace Demo.ViewModels
{
    public class AttendenceWithCourses
    {
        public int Doc_id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string doc_Name { get; internal set; }
        public int Student_ID { get; set; }
        public int Attendence_count { get; set; }
        public int Attendence_max { get; set; }
        public int Course_id { get; set; }
    }
}
