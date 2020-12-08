using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using AppContext;
using AppContext.Models;
using System.ComponentModel.DataAnnotations;
using WebApp.Helpers;

using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Pages
{
    public class AddGroupModel : PageModel
    {
        public List<string> PeriodTypes { get; set; }

        [BindProperty]
        public string PeriodType { get; set; }

        [BindProperty(SupportsGet=true)]
        public bool HasError { get; set; }

        public void OnGet()
        {
            ViewData["title"] = "Add Group";
        }

        private School db;

        private GroupBuilderHelper helper;

        public AddGroupModel(School injecteddb)
        {
            db = injecteddb;
            helper = new GroupBuilderHelper(db);

            PeriodTypes = new List<string>();
            var periodTypes = db.PeriodKinds;
            foreach (var periodType in periodTypes)
            {
                PeriodTypes.Add(periodType.Name);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var periodTypes = db.PeriodKinds;
                PeriodKind periodType = new PeriodKind();
                foreach(var item in periodTypes)
                {
                    if (item.Name == PeriodType)
                    {
                        periodType = item;
                    }
                }

                SchoolGroup group = new SchoolGroup()
                {
                    Name = helper.CreateName(), 
                    IdPeriodKind = periodType.IdPeriodKind, 
                    StartDate = helper.RoundDate(DateTime.Now), 
                    CloseDate = helper.RoundDate(DateTime.Now.AddMonths(periodType.Months))
                };

                db.SchoolGroups.Add(group);
                db.SaveChanges();
                return RedirectToPage("../search/groups");

            }

            HasError = true;
            return RedirectToPage("add_group", new { HasError } );
        }
    }
}