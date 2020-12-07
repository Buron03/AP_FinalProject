using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;

namespace WebApp.Pages
{
   public class TeachersModel : PageModel
   {
       public IEnumerable<Teacher> Teachers { get; set; }
       
       private School db;
    
       public TeachersModel(School injectedContext)
       {
           db = injectedContext;
       }

       public void OnGet()
       {
           ViewData["Title"] = "Teachers";
           Teachers = db.Teachers;
       }
   } 
}