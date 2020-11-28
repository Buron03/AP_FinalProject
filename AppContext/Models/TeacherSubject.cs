using System;
using System.ComponentModel.DataAnnotations;

namespace AppContext.Models
{
    public class TeacherSubject
    {
        [Key]
        public int IdTeacherSubject { get; set; }

        public int IdTeacher { get; set; }
        public int IdSubject { get; set; }
    }
}
