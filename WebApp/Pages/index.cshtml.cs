using static System.Console;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;

using System.ComponentModel.DataAnnotations;

namespace WebApp.Pages.Models
{
   public class StartModel : PageModel
   {
       public IEnumerable<Teacher> Teachers { get; set; }

       [BindProperty]
       [Required]
       public string TextUsername { get; set; }
       
       [BindProperty]
       [Required]
       [DataType(DataType.Password)]
       public string TextPassword { get; set; }
       
       [BindProperty(SupportsGet = true)]
       public bool HasError { get; set; }
      
       private School db;
    
       public StartModel(School injectedContext)
       {
           db = injectedContext;
           HasError = false;
       }

       public void OnGet()
       {
           ViewData["Title"] = "Login";
       }

       public IActionResult OnPost()
       {
           if(ModelState.IsValid)
           {
               int payrollNumber;

               if (int.TryParse(TextUsername, out payrollNumber))
               {
                   Teachers = db.Teachers;
                   foreach (var teacher in Teachers)
                   {
                       if (teacher.PayrollNumber == payrollNumber && teacher.Password == TextPassword)
                       {
                           return RedirectToPage("/menu");
                       }
                   }
               }
           }
           
           HasError = true;
           return RedirectToPage("/index", new { HasError });
       }
   }
}