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
using System.Web;    
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Pages
{
    public class AddTeacherModel : PageModel
    {   
        //Bind the state
        [BindProperty]
        public State State { get; set; }

        //Catch the birth date
        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }


        //Cathc Teacher Type List
        public List<string> ListTeachers { get; set; }

        [BindProperty]
        public string TeacherKind { get; set; }


        //Names Properties
        [BindProperty]
        public string FirstName { get; set; }

        [BindProperty]
        public string SecondName { get; set; }

        [BindProperty]
        public string FirstSurname { get; set; }

        [BindProperty]
        public string SecondSurname { get; set; }


        //HasError watcher
        [BindProperty]
        public bool HasError { get; set; } 


        //Database and constructor
        private School db;

        private TeacherBuilderHelper helper;

        public AddTeacherModel(School injectedDatabase)
        {
            db = injectedDatabase;
            ListTeachers = new List<string>();
            var TeacherKinds = db.TeacherKinds;
            foreach (var TeacherKind in TeacherKinds)
            {
                ListTeachers.Add(TeacherKind.Name);
            }
            helper = new TeacherBuilderHelper(db);
        }

        //Gender
        [BindProperty]
        public string Gender { get; set; }

        public void OnGet()
        {
            ViewData["title"] = "Add Teacher";
        }

        public IActionResult OnPost()
        {
            TeacherKind teacherKind = new TeacherKind();            
            foreach (var someType in db.TeacherKinds)
            {
                if (someType.Name == TeacherKind)
                {
                    teacherKind = someType;
                }    
            }

            if (ModelState.IsValid)
            {
                //Fill Helper
                helper.FirstName = FirstName;
                helper.SecondName = SecondName;
                helper.FirstSurname = FirstSurname;
                helper.SecondSurname = SecondSurname;
                helper.Gender = Gender;
                helper.State = State;
                helper.DateOfBirth = DateOfBirth;
                
                //Build Teacher with helper
                Teacher newTeacher = new Teacher();
                newTeacher.IdTeacherKind = teacherKind.IdTeacherKind;
                newTeacher.FirstName = FirstName;
                newTeacher.SecondName = SecondName; 
                newTeacher.FirstSurname = FirstSurname;
                newTeacher.SecondSurname = SecondSurname; 
                newTeacher.DateOfBirth = DateOfBirth;
                newTeacher.Rfc = helper.CreateRFC();
                newTeacher.Curp = helper.CreateCURP(); 
                newTeacher.PayrollNumber = helper.CreatePaycheckNumber(); 
                newTeacher.Password = helper.CreatePassword();

                db.Teachers.Add(newTeacher);
                db.SaveChanges();

                HasError = true;
                return RedirectToPage("../search/teachers");
            }

            HasError = true;
            return RedirectToPage("add_teacher", new { HasError });
        }
    }
}

