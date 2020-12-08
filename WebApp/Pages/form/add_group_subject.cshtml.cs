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
   public class AddGroupSubjectModel : PageModel
   {
       //Display Properties
       public IEnumerable<GroupSubject> GroupSubjects { get; set; }

       public IEnumerable<SchoolGroup> Groups { get; set; }
       
       public IEnumerable<Subject> Subjects { get; set; }

       private School db;

       private ProgramHelper helper;


        //Selection Properties
        [BindProperty]
        public string GroupID { get; set; }

        [BindProperty]
        public string SubjectID { get; set; }
    
       public AddGroupSubjectModel(School injectedContext)
       {
           db = injectedContext;
           helper = new ProgramHelper(db);
           GroupSubjects = db.GroupSubjects;          
           Groups = db.SchoolGroups;
           Subjects = db.Subjects;
       }

       public void OnGet()
       {
           ViewData["Title"] = "Add Group Subject";
       }

        public List<GroupSubject> GetGroupSubjects(int IdGroup)
        {
            return helper.GetGroupSubjects(IdGroup);
        }

        public bool LessThanMaxGroupSubjects(SchoolGroup group)
        {
            return helper.LessThanMaxGroupSubjects(group.IdGroup);
        }

        public Subject GetSubject(GroupSubject groupSubject)
        {
            return helper.GetSubject(groupSubject.IdSubject);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Subject subject = new Subject();
                foreach (var item in db.Subjects)
                {
                    if (int.Parse(SubjectID) == item.IdSubject)
                    {
                        subject = item;
                    }
                }

                SchoolGroup schoolGroup = new SchoolGroup();
                foreach (var item in db.SchoolGroups)
                {
                    if (int.Parse(GroupID) == item.IdGroup)
                    {
                        schoolGroup = item;
                    }
                }

                if (schoolGroup.Name == null || subject.Name == null)
                {
                     return RedirectToPage("add_group_subject");
                }

                bool flag = true;
                foreach (var groupSubject in GroupSubjects)
                {
                    if (groupSubject.IdGroup == schoolGroup.IdGroup && groupSubject.IdSubject == subject.IdSubject)
                    {
                        flag = false;
                        break;
                    }
                }

                //If flag then is a new Groups SchoolGroup row
                if (flag)
                {
                    GroupSubject GroupSubject = new GroupSubject()
                    {
                        IdGroup = schoolGroup.IdGroup,
                        IdSubject = subject.IdSubject
                    };

                    db.GroupSubjects.Add(GroupSubject);
                    db.SaveChanges();
                }
            }

            return RedirectToPage("add_group_subject");
        }
   } 
}