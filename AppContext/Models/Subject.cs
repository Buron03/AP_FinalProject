using System;
using System.ComponentModel.DataAnnotations;

namespace AppContext.Models
{
    public class Subject
    {
        [Key]
        public int IdSubject { get; set; }
        public string Name { get; set; }
        public int TheoreticalHours { get; set; }
        public int PracticalHours { get; set; }
    }
}
