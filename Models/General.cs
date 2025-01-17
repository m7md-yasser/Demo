using Demo.Models;

namespace Demo.Models
{
    public class General
    {
        public List<Student> Students = new List<Student> {
        new Student { Id = 300243,password="mohamed300", Name = "Mohamed", Address = "Desouk", Image = "01.jpg" ,level =1 ,Email ="Mohammed@gmail.com"},
        new Student { Id = 300343,password="yousef300", Name = "Yousef", Address = "Alex", Image = "02.jpg",level =2 , Email ="Yousef@gmail.com"},
        new Student { Id = 300454,password="ahmed300", Name = "Ahmed", Address = "Cairo", Image = "03.jpg",level =3 ,Email ="Ahmed@gmail.com"},
        new Student { Id = 300656,password="mahmoud300", Name = "Mahmoud", Address = "Luxor", Image = "04.jpg",level =4 ,Email ="Mahmoud@gmail.com"},
        new Student { Id = 300611,password="salma300", Name = "Salma", Address = "Assuit", Image = "05.jpg",level =4 ,Email ="Salma@gmail.com"},
        new Student { Id = 300622,password="nancy300", Name = "Nancy", Address = "Fayoum", Image = "06.jpg",level =4 ,Email ="Nancy@gmail.com"} };

        public List<Doctor> doctors = new List<Doctor>
        {
        new Doctor { Id = 200321,Password ="nada200",   Name = "Nada ",  Image = "5.jpg" ,Email ="Nada@gmail.com"  },
        new Doctor { Id = 200435,Password ="ali200",    Name = "ALi ",  Image = "6.jpg",  Email ="Ali@gmail.com" },
        new Doctor { Id = 200543,Password ="mostafa200",Name = "Mostafa ", Image ="7.jpg",Email ="Mostafa@gmail.com"},
        new Doctor { Id = 200654,Password ="layla200",  Name = "Layla ", Image = "8.jpeg",Email ="Layla@gmail.com" } ,
        new Doctor { Id = 200633,Password ="yousef200", Name = "Yousef ", Image = "9.jpg",Email ="Yousef@gmail.com" } };
       
        public List<DoctorWithCourses> DoctorCourses = new List<DoctorWithCourses>
        {
        new DoctorWithCourses { Course_Id = 6,Student_Count = 3, Name = "Data_Structre", Description = "Data_Structre & Algorthims", Image = "15.png", Doctor_ID = 200543, Doc_Name = "Mostafa 💪🏻" } ,
        new DoctorWithCourses { Course_Id = 2,Student_Count = 4, Name = "SE", Description = "Software Engineering",  Image = "11.jpeg", Doctor_ID =200321,Doc_Name = "Nada 👑" },
        new DoctorWithCourses { Course_Id = 6,Student_Count = 3, Name = "Data_Structre",  Description = "Data_Structre & Algorthims" ,Image = "15.png",Doctor_ID =200435 ,Doc_Name = "ALi 💪🏻"},
        new DoctorWithCourses { Course_Id = 1,Student_Count = 3, Name = "CS", Description = "Computer Science" ,Image = "111.png" , Doctor_ID =200611 ,Doc_Name = "Yousef 💪🏻", },
        new DoctorWithCourses { Course_Id = 2,Student_Count = 4, Name = "SE", Description = "Software Engineering",  Image = "11.jpeg", Doctor_ID =200654,Doc_Name = "Layla 👑" },
        new DoctorWithCourses { Course_Id = 4,Student_Count = 4, Name = "IT",  Description = "Information Technology",Image = "13.jpeg" ,Doctor_ID =200435,Doc_Name = "ALi 💪🏻" },
        new DoctorWithCourses { Course_Id = 3,Student_Count = 4, Name = "IS",  Description = "Information Systems", Image = "12.png",Doctor_ID =200321,  Doc_Name = "Nada 👑" },
        new DoctorWithCourses { Course_Id = 5,Student_Count = 3, Name = "Database",Description = "fundamental Database", Image = "14.jpeg" ,Doctor_ID =200435,Doc_Name = "Ali 💪🏻"},
        new DoctorWithCourses { Course_Id = 3,Student_Count = 4, Name = "IS",  Description = "Information Systems", Image = "12.png",Doctor_ID =200654,  Doc_Name = "Layla 👑" },
        new DoctorWithCourses { Course_Id = 4,Student_Count = 4, Name = "IT",  Description = "Information Technology",Image = "13.jpeg" ,Doctor_ID =200654,Doc_Name = "Layla 👑" },
        new DoctorWithCourses { Course_Id = 5,Student_Count = 3, Name = "Database",Description = "fundamental Database", Image = "14.jpeg" ,Doctor_ID =200611,Doc_Name = "Yousef 💪🏻"},
        new DoctorWithCourses { Course_Id = 6,Student_Count = 3, Name = "Data_Structre",  Description = "Data_Structre & Algorthims" ,Image = "15.png",Doctor_ID =200611 ,Doc_Name = "Yousef 💪🏻"},
        new DoctorWithCourses { Course_Id = 1,Student_Count = 3, Name = "CS", Description = "Computer Science" ,Image = "111.png" , Doctor_ID =200543 ,Doc_Name = "Mostafa 💪🏻", },
        new DoctorWithCourses { Course_Id = 2,Student_Count = 4, Name = "SE", Description = "Software Engineering",  Image = "11.jpeg", Doctor_ID =200435,Doc_Name = "Ali 💪🏻" },
        new DoctorWithCourses { Course_Id = 3,Student_Count = 4, Name = "IS", Description = "Information Systems", Image = "12.png", Doctor_ID = 200654, Doc_Name = "Layla 👑" },
        new DoctorWithCourses { Course_Id = 1,Student_Count = 3, Name = "CS", Description = "Computer Science" ,Image = "111.png" , Doctor_ID =200321 ,Doc_Name = "Nada 👑", },
        new DoctorWithCourses { Course_Id = 4,Student_Count = 4, Name = "IT", Description = "Information Technology", Image = "13.jpeg", Doctor_ID = 200321, Doc_Name = "Nada 👑" },
        new DoctorWithCourses { Course_Id = 5,Student_Count = 3, Name = "Database", Description = "fundamental Database", Image = "14.jpeg", Doctor_ID = 200543, Doc_Name = "Mostafa 💪🏻" }};
        
        public List<Course> Courses = new List<Course>
        {
        new Course { Id = 1, Name = "CS", Description = "Computer Science" ,Image = "111.png" , Doctor_ID =200321 ,Student_ID =  300243,doc_Name = "Nada", },
        new Course { Id = 2, Name = "SE", Description = "Software Engineering",  Image = "11.jpeg", Doctor_ID =200321,Student_ID =  300243,doc_Name = "ALi" }  ,
        new Course { Id = 3, Name = "IS",  Description = "Information Systems", Image = "12.png",Doctor_ID =200321,Student_ID =  300243,  doc_Name = "Layla" },
        new Course { Id = 4, Name = "IT",  Description = "Information Technology",Image = "13.jpeg" ,Doctor_ID =200435,Student_ID =  300343 ,doc_Name = "Layla" },
        new Course { Id = 5, Name = "Database",Description = "fundamental Database", Image = "14.jpeg" ,Doctor_ID =200435,Student_ID =  300343 ,doc_Name = "Yousef"},
        new Course { Id = 6, Name = "Data_Structre",  Description = "Data_Structre & Algorthims" ,Image = "15.png",Doctor_ID =200435 ,Student_ID =  300343,doc_Name = "Yousef"} };
        public List<Attendnece> attendneces = new List<Attendnece>
       {
        new Attendnece { id = 1,  Course_ID = 1, Student_ID =300243 ,Attendence_count = 4,Attendence_max =7},
        new Attendnece { id = 2,  Course_ID = 2, Student_ID =300243,Attendence_count = 5,Attendence_max =7},
        new Attendnece { id = 3,  Course_ID = 3, Student_ID =300243,Attendence_count = 4,Attendence_max =8},
        new Attendnece { id = 5,  Course_ID = 4, Student_ID =300343 ,Attendence_count = 7,Attendence_max =8} ,
        new Attendnece { id = 6,  Course_ID = 1, Student_ID =300343,Attendence_count = 5,Attendence_max =7} ,
        new Attendnece { id = 7,  Course_ID = 6, Student_ID =300343,Attendence_count = 5,Attendence_max =10} ,
        new Attendnece { id = 4,  Course_ID = 5, Student_ID =300454,Attendence_count = 8,Attendence_max =10},
        new Attendnece { id = 8,  Course_ID = 6, Student_ID =300454,Attendence_count = 7,Attendence_max =10 },
        new Attendnece { id = 9,  Course_ID = 2, Student_ID =300454,Attendence_count = 7,Attendence_max =7},
        new Attendnece { id = 10, Course_ID = 5, Student_ID =300656,Attendence_count = 9,Attendence_max =10},
        new Attendnece { id = 11, Course_ID = 3, Student_ID =300656,Attendence_count = 7,Attendence_max =8},
        new Attendnece { id = 12, Course_ID = 4, Student_ID =300656,Attendence_count = 7 ,Attendence_max =8},
        new Attendnece { id = 13, Course_ID = 2, Student_ID =300611,Attendence_count = 5,Attendence_max =7},
        new Attendnece { id = 14, Course_ID = 3, Student_ID =300611,Attendence_count = 3 ,Attendence_max =8},
        new Attendnece { id = 15, Course_ID = 4, Student_ID =300611,Attendence_count = 1,Attendence_max =8},
        new Attendnece { id = 16, Course_ID = 5, Student_ID =300622,Attendence_count = 6,Attendence_max =10},
        new Attendnece { id = 17, Course_ID = 6, Student_ID =300622,Attendence_count = 5,Attendence_max =10},
        new Attendnece { id = 18, Course_ID = 4, Student_ID =300622,Attendence_count = 6,Attendence_max =8},
        new Attendnece { id = 19, Course_ID = 2, Student_ID =300656,Attendence_count = 6,Attendence_max =7},
        new Attendnece { id = 20, Course_ID = 3, Student_ID =300622,Attendence_count = 6,Attendence_max =8},
        new Attendnece { id = 21, Course_ID = 1, Student_ID =300611,Attendence_count = 5,Attendence_max =7} };

        public List<Lectures> lectures = new List<Lectures>
        {
            new Lectures { Course_ID =1 ,  LectureLinks = new List<string>
            {
                "https://www.youtube.com/embed/dQw4w9WgXcQ", // فيديو 1
                "https://www.youtube.com/embed/dQw4w9WgXcQ", // فيديو 1
                "https://www.youtube.com/embed/dQw4w9WgXcQ", // فيديو 1
                "https://www.youtube.com/embed/dQw4w9WgXcQ", // فيديو 1
                "https://www.youtube.com/embed/3JZ_D3ELwOQ", // فيديو 2
                "https://www.youtube.com/embed/3JZ_D3ELwOQ", // فيديو 2
                "https://www.youtube.com/embed/3JZ_D3ELwOQ", // فيديو 2
                "https://www.youtube.com/embed/3JZ_D3ELwOQ", // فيديو 2
                "https://www.youtube.com/embed/tgbNymZ7vqY",  // فيديو 3
                "https://www.youtube.com/embed/tgbNymZ7vqY",  // فيديو 3
                "https://www.youtube.com/embed/tgbNymZ7vqY",  // فيديو 3
                "https://www.youtube.com/embed/tgbNymZ7vqY", // فيديو 3
            }},
            new Lectures { Course_ID =2},
            new Lectures { Course_ID =3},
            new Lectures { Course_ID =4},
            new Lectures { Course_ID =5},
            new Lectures { Course_ID =6 }
         
        };

        public List<User> Users = new List<User>
        {
            new User { id = 200321,password ="nada200",    link ="http://localhost:56652/Course/DoctorPage/200321"},
            new User { id = 200435,password ="ali200",     link ="http://localhost:56652/Course/DoctorPage/200435"},
            new User { id = 200543,password ="mostafa200", link ="http://localhost:56652/Course/DoctorPage/200543"},
            new User { id = 200654,password ="layla200",   link ="http://localhost:56652/Course/DoctorPage/200654"},
            new User { id = 200633,password ="yousef200",  link ="http://localhost:56652/Course/StudentPage/200633" },
            new User { id = 300243,password="mohamed300",  link ="http://localhost:56652/Student/StudentPage/300243"},
            new User { id = 300343,password="yousef300",   link ="http://localhost:56652/Student/StudentPage/300343"},
            new User { id = 300454,password="ahmed300",    link ="http://localhost:56652/Student/StudentPage/300454"},
            new User { id = 300656,password="mahmoud300",  link ="http://localhost:56652/Student/StudentPage/300656"},
            new User { id = 300611,password="salma300",    link ="http://localhost:56652/Student/StudentPage/200611"},
            new User { id = 300622,password="nancy300",    link ="http://localhost:56652/Student/StudentPage/200622"}

        };
        }
    
}


   

