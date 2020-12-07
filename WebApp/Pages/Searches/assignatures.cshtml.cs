using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;

namespace WebApp.Pages
{
   public class AssignaturesModel : PageModel
   {
       public IEnumerable<Assignature> Assignatures { get; set; }
       
       private School db;
    
       public AssignaturesModel(School injectedContext)
       {
           db = injectedContext;
       }

       public void OnGet()
       {
           ViewData["Title"] = "Assignature";
           Assignatures = db.Assignatures;
       }
   } 
}