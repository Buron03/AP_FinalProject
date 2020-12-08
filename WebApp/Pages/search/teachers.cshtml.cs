using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;
using static AppContext.Const.Constant;

using WebApp.Helpers;

namespace WebApp.Pages
{
   public class TeachersModel : PageModel
   {
       public IEnumerable<Teacher> Teachers { get; set; }
       
       private School db;

       private ProgramHelper helper;
    
       public TeachersModel(School injectedContext)
       {
           db = injectedContext;
           helper = new ProgramHelper(db);
       }

       public void OnGet()
       {
           ViewData["Title"] = "Teachers";
           Teachers = db.Teachers;
       }

        public bool GetTeacherStatus(Teacher teacher)
        {
            return helper.GetTeacherStatus(teacher);
        }

        public int GetTotalSubjects(int IdTeacher)
        {
            return helper.GetTotalSubjects(IdTeacher);
        }

        public int GetTotalHours(int IdTeacher)
        {
            return helper.GetTotalHours(IdTeacher);
        }

        public TeacherKind GetKind(int IdTeacherKind)
        {
            return helper.GetKind(IdTeacherKind);
        }

        public int GetTotalGroups(int IdTeacher)
        {
            return helper.GetTotalGroups(IdTeacher);
        }

   } 
}