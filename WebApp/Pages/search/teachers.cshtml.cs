using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;
using static AppContext.Const.Constant;

namespace WebApp.Pages
{
   public class TeachersModel : PageModel
   {
       public IEnumerable<Teacher> Teachers { get; set; }
       
       private School db;
    
       public TeachersModel(School injectedContext)
       {
           db = injectedContext;
       }

       public void OnGet()
       {
           ViewData["Title"] = "Teachers";
           Teachers = db.Teachers;
       }

       public TeacherKind GetKind(int IdTeacherKind)
       {
           IEnumerable<TeacherKind> kinds = db.TeacherKinds;
           foreach (var kind in kinds)
           {
               if (kind.IdTeacherKind == IdTeacherKind)
               {
                   return kind;
               }
           }
           return null;
       }

       public int GetTotalHours(int IdTeacher)
       {
           IEnumerable<Assignature> assignatures = db.Assignatures;
           int total = 0;
           foreach (var assignature in assignatures)
           {
               if (assignature.IdTeacher == IdTeacher)
               {
                   Subject subject = GetSubject(assignature.IdSubject);
                   total += (subject.PracticalHours + subject.TheoreticalHours);
               }
           }
           return total;
       }

        private Subject GetSubject(int IdSubject)
        {
            IEnumerable<Subject> subjects = db.Subjects;
            foreach (var subject in subjects)
            {
                if (subject.IdSubject == IdSubject)
                {
                    return subject;
                }
            }
            return null;
        }

        public int GetTotalGroups(int IdTeacher)
        {
            IEnumerable<Assignature> assignatures = db.Assignatures;
            List<SchoolGroup> groups = new List<SchoolGroup>();

            int total = 0;

            foreach (var assignature in assignatures)
            {
                if (assignature.IdTeacher == IdTeacher && IsNewGroup(groups, assignature.IdGroup))
                {
                    SchoolGroup group = GetGroup(assignature.IdGroup);
                    groups.Add(group);
                    total++;
                }
            }

            return total;
        }

        private bool IsNewGroup(List<SchoolGroup> groups, int IdGroup)
        {
            foreach (var group in groups)
            {
                if (group.IdGroup == IdGroup)
                {
                    return false;
                }
            }
            return true;
        }

        private SchoolGroup GetGroup(int IdGroup)
        {
            IEnumerable<SchoolGroup> groups = db.SchoolGroups;
            foreach (var group in groups)
            {
                if (group.IdGroup == IdGroup)
                {
                    return group;
                }
            }
            return null;
        }

        public int GetTotalSubjects(int IdTeacher)
        {
            IEnumerable<TeacherSubject> teacherSubjects = db.TeacherSubjects;
            int total = 0;

            foreach (var teacherSubject in teacherSubjects)
            {
                if (teacherSubject.IdTeacher == IdTeacher)
                {
                    total++;
                }
            }

            return total;
        }

        public bool GetStatus(Teacher teacher)
        {
            return (IsGroupsOk(teacher) && IsHoursOk(teacher) && IsSubjectsOk(teacher));
        }

        private bool IsHoursOk(Teacher teacher)
        {
            int hours = GetTotalHours(teacher.IdTeacher);
            TeacherKind kind = GetKind(teacher.IdTeacherKind);
            return (hours >= kind.MinHours && hours <= kind.MaxHours);
        }

        private bool IsGroupsOk(Teacher teacher)
        {
            int totalGroups = GetTotalGroups(teacher.IdTeacher);
            return (totalGroups >= MIN_GROUPS && totalGroups <= MAX_GROUPS);
        }

        private bool IsSubjectsOk(Teacher teacher)
        {
            int totalSubjects = GetTotalSubjects(teacher.IdTeacher);
            return (totalSubjects >= MIN_SUBJECTS && totalSubjects <= MAX_SUBJECTS);
        }
   } 
}