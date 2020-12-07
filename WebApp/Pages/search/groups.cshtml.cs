using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;

namespace WebApp.Pages
{
   public class GroupsModel : PageModel
   {
       public IEnumerable<SchoolGroup> Groups { get; set; }
       
       private School db;
    
       public GroupsModel(School injectedContext)
       {
           db = injectedContext;
       }

       public void OnGet()
       {
           ViewData["Title"] = "Groups";
           Groups = db.SchoolGroups;
       }
   } 
}