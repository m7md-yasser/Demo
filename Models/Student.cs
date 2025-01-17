using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace Demo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int level { get; set; }
        public string Email { get; internal set; }
    }
}
