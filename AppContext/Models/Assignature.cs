using System;
using System.ComponentModel.DataAnnotations;

namespace AppContext.Models
{
    public class Assignature
    {
        [Key]
        public int IdAssignature { get; set; }

        public int IdTeacher { get; set; }
        public int IdSubject { get; set; }
        public int IdGroup { get; set; }
    }
}
