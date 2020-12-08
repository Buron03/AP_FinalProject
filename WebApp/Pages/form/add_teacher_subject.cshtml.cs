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
    public class AddTeacherSubjectModel : PageModel
    {
        public List<string> TeachersNames { get; set; }
        public List<string> SubjectsNames { get; set; }

        
        
        
        [BindProperty(SupportsGet=true)]
        public bool HasError { get; set; }

        [BindProperty]
        public string ChoosenSubjectsNames { get; set; }

        [BindProperty]
        public string TeacherName { get; set; }

        public void OnGet()
        {
            ViewData["title"] = "Add Group";
        }

        private School db;

        private GroupBuilderHelper helper;

        public AddTeacherSubjectModel(School injecteddb)
        {
            db = injecteddb;
            helper = new GroupBuilderHelper(db);

            TeachersNames = new List<string>();
            var teachers = db.Teachers;
            foreach (var teacher in teachers)
            {
                TeachersNames.Add(teacher.FirstName + " " + teacher.FirstSurname);
            }

            SubjectsNames = new List<string>();
            var subjects = db.Subjects;
            foreach (var subject in subjects)
            {
                SubjectsNames.Add(subject.Name);
            }
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("add_teacher_subject", new { ChoosenSubjectsNames });
        }
    }
}