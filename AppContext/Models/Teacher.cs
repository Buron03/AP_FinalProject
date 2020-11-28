using System;
using System.ComponentModel.DataAnnotations;

namespace AppContext.Models
{
    public class Teacher
    {
        [Key]
        public int IdTeacher { get; set; }

        public int IdTeacherKind { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public int PayrollNumber { get; set; }
        public string Password { get; set; }
    }
}
