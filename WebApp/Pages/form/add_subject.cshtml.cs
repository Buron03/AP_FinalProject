using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using AppContext.Models;
using AppContext;
using WebApp.Helpers;

using System.ComponentModel.DataAnnotations;

using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Pages
{
    public class AddSubjectModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int TheoreticalHours { get; set; }

        [BindProperty]
        public int PracticalHours { get; set; }         

        [BindProperty(SupportsGet=true)]
        public bool HasError { get; set; }



        private School db;

        private ProgramHelper helper;



        public AddSubjectModel(School injectedDatabase)
        {
            db = injectedDatabase;
            helper = new ProgramHelper(db);
        }

        public void OnGet()
        {
            ViewData["title"] = "Add Subject";
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Subject subject = new Subject()
                {
                    Name = Name, 
                    TheoreticalHours = TheoreticalHours, 
                    PracticalHours = PracticalHours
                };
                
                if (helper.IsAValidSubject(subject))
                {
                    db.Subjects.Add(subject);
                    db.SaveChanges();
                    return RedirectToPage("../search/subjects");
                }
            }

            HasError = true;
            return RedirectToPage("add_subject", new { HasError });
        }
    }
}