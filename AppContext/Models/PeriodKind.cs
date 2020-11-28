using System;
using System.ComponentModel.DataAnnotations;

namespace AppContext.Models
{
    public class PeriodKind
    {
        [Key]
        public int IdPeriodKind { get; set; }
        
        public string Name { get; set; }
        public int Months { get; set; }
    }
}
