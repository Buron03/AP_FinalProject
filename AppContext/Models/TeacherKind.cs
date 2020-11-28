using System;
using System.ComponentModel.DataAnnotations;

namespace AppContext.Models
{
    public class TeacherKind
    {
        [Key]
        public int IdTeacherKind { get; set; }
        
        public string Name { get; set; }
        public int MinHours { get; set; }
        public int MaxHours { get; set; }
    }
}
