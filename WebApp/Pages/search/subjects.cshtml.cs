using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;

using WebApp.Helpers;

namespace WebApp.Pages
{
   public class SubjectsModel : PageModel
   {
       public IEnumerable<Subject> Subjects { get; set; }
       
       private School db;

       private ProgramHelper helper;
    
       public SubjectsModel(School injectedContext)
       {
           db = injectedContext;
           helper = new ProgramHelper(db);
       }

       public void OnGet()
       {
           ViewData["Title"] = "Subjects";
           Subjects = db.Subjects;
       }

       public int GetTotalTeachersOfSubject(int IdSubject)
       {
           return helper.GetTotalTeachersOfSubject(IdSubject);
       }
   } 
}