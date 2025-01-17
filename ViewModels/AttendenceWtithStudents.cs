namespace Demo.ViewModels
{
    public class AttendenceWtithStudents
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string image { get; set; }
        public int level { get; set; }
        public int attend_count { get; set; }
        public int attend_Max {  get; set; }
        public string Address { get; internal set; }
        public int Course_ID { get; internal set; }
    }
}
