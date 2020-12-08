using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;

using WebApp.Helpers;

namespace WebApp.Pages
{
   public class GroupsModel : PageModel
   {
       public IEnumerable<SchoolGroup> Groups { get; set; }
       
       private School db;
    
       private ProgramHelper helper;

       public GroupsModel(School injectedContext)
       {
           db = injectedContext;
           helper = new ProgramHelper(db);
       }

       public void OnGet()
       {
           ViewData["Title"] = "Groups";
           Groups = db.SchoolGroups;
       }

        public PeriodKind GetPeriodKind(int IdPeriodKind)
        {
            return helper.GetPeriodKind(IdPeriodKind);
        }

        public int GetTotalHoursGroup(int IdGroup)
        {
            return helper.GetTotalHoursGroup(IdGroup);
        }

        public int GetTotalTeachersOfGroup(int IdGroup)
        {
            return helper.GetTotalTeachersOfGroup(IdGroup);
        }

        public int GetTotalSubjectsOfGroup(int IdGroup)
        {
            return helper.GetTotalSubjectsOfGroup(IdGroup);
        }

        public bool GetGroupStatus(int IdGroup)
        {
            return helper.GetGroupStatus(IdGroup);
        }
   } 
}