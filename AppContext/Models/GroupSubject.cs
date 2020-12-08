using System;
using System.ComponentModel.DataAnnotations;

namespace AppContext.Models
{
    public class GroupSubject
    {
        [Key]
        public int IdGroupSubject { get; set; }

        public int IdGroup { get; set; } 
        public int IdSubject { get; set; }
    }
}