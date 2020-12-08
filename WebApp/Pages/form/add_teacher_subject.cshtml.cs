using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;

using WebApp.Helpers;

using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Pages
{
   public class AddTeacherSubjectModel : PageModel
   {
       //Display Properties
       public IEnumerable<TeacherSubject> TeacherSubjects { get; set; }

       public IEnumerable<Teacher> Teachers { get; set; }
       
       public IEnumerable<Subject> Subjects { get; set; }

       private School db;

       private ProgramHelper helper;


        //Selection Properties
        [BindProperty]
        public string TeacherID { get; set; }

        [BindProperty]
        public string SubjectID { get; set; }
    
       public AddTeacherSubjectModel(School injectedContext)
       {
           db = injectedContext;
           helper = new ProgramHelper(db);
           TeacherSubjects = db.TeacherSubjects;          
           Teachers = db.Teachers;
           Subjects = db.Subjects;
       }

       public void OnGet()
       {
           ViewData["Title"] = "Add Teacher Subject";
       }

        public List<TeacherSubject> GetTeacherSubjects(int IdTeacher)
        {
            return helper.GetTeacherSubjects(IdTeacher);
        }

        public bool LessThanMaxSubjects(Teacher teacher)
        {
            return helper.LessThanMaxSubjects(teacher.IdTeacher);
        }

        public Subject GetSubject(TeacherSubject teacherSubject)
        {
            return helper.GetSubject(teacherSubject.IdSubject);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Teacher teacher = new Teacher();
                foreach (var item in Teachers)
                {
                    if (int.Parse(TeacherID) == item.IdTeacher)
                    {
                        teacher = item;
                    }
                }

                Subject subject = new Subject();
                foreach (var item in db.Subjects)
                {
                    if (int.Parse(SubjectID) == item.IdSubject)
                    {
                        subject = item;
                    }
                }

                if (teacher.FirstName == null || subject.Name == null)
                {
                     return RedirectToPage("add_teacher_subject", new { teacher.FirstName } );
                }

                bool flag = true;
                foreach (var teacherSubject in TeacherSubjects)
                {
                    if (teacherSubject.IdSubject == subject.IdSubject && teacher.IdTeacher == teacherSubject.IdTeacher)
                    {
                        flag = false;
                        break;
                    }
                }

                //If flag then is a new teacher subject row
                if (flag)
                {
                    TeacherSubject teacherSubject = new TeacherSubject()
                    {
                        IdSubject = subject.IdSubject,
                        IdTeacher = teacher.IdTeacher
                    };

                    db.TeacherSubjects.Add(teacherSubject);
                    db.SaveChanges();
                }
            }

            return RedirectToPage("add_teacher_subject", new { TeacherID } );
        }
   } 
}