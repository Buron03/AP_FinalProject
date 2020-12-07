using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;

namespace WebApp.Pages
{
   public class SubjectsModel : PageModel
   {
       public IEnumerable<Subject> Subjects { get; set; }
       
       private School db;
    
       public SubjectsModel(School injectedContext)
       {
           db = injectedContext;
       }

       public void OnGet()
       {
           ViewData["Title"] = "Subjects";
           Subjects = db.Subjects;
       }
   } 
}