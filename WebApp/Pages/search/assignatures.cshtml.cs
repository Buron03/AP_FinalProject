using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;

using WebApp.Helpers;

namespace WebApp.Pages
{
   public class AssignaturesModel : PageModel
   {
       public IEnumerable<Assignature> Assignatures { get; set; }

       public IEnumerable<Teacher> Teachers { get; set; }

       private School db;

       private ProgramHelper helper;
    
       public AssignaturesModel(School injectedContext)
       {
           db = injectedContext;
           helper = new ProgramHelper(db);
       }

       public void OnGet()
       {
           ViewData["Title"] = "Assignature";
           Assignatures = db.Assignatures;
           Teachers = db.Teachers;
       }

        public List<Assignature> GetTeacherAssignatures(int IdTeacher)
        {
            return helper.GetTeacherAssignatures(IdTeacher);
        }

        public Subject GetSubject(Assignature assignature)
        {
            return helper.GetSubject(assignature.IdSubject);
        }

        public SchoolGroup GetGroup(Assignature assignature)
        {
            return helper.GetGroup(assignature.IdGroup);
        }
   } 
}