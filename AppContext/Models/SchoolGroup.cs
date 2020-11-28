using System;
using System.ComponentModel.DataAnnotations;

namespace AppContext.Models
{
    public class SchoolGroup
    {
        [Key]
        public int IdGroup { get; set; }

        public int IdPeriodKind { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CloseDate { get; set; }
    }
}
