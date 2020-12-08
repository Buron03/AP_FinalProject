using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;
using static AppContext.Const.Constant;

namespace WebApp.Helpers
{
    public class ProgramHelper
    {
        private School db;

        public ProgramHelper(School db)
        {
            this.db = db;
        }


        //Methods
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

        public Subject GetSubject(int IdSubject)
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
                SchoolGroup group = GetGroup(assignature.IdGroup);
                if (assignature.IdTeacher == IdTeacher && !groups.Contains(group))
                {
                    groups.Add(group);
                    total++;
                }
            }

            return total;
        }

        public SchoolGroup GetGroup(int IdGroup)
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

        public bool GetTeacherStatus(Teacher teacher)
        {
            return (IsGroupsOk(teacher) && IsHoursOk(teacher) && IsSubjectsOk(teacher));
        }

        public bool IsHoursOk(Teacher teacher)
        {
            int hours = GetTotalHours(teacher.IdTeacher);
            TeacherKind kind = GetKind(teacher.IdTeacherKind);
            return (hours >= kind.MinHours && hours <= kind.MaxHours);
        }

        public bool IsGroupsOk(Teacher teacher)
        {
            int totalGroups = GetTotalGroups(teacher.IdTeacher);
            return (totalGroups >= MIN_GROUPS && totalGroups <= MAX_GROUPS);
        }

        public bool IsSubjectsOk(Teacher teacher)
        {
            int totalSubjects = GetTotalSubjects(teacher.IdTeacher);
            return (totalSubjects >= MIN_SUBJECTS && totalSubjects <= MAX_SUBJECTS);
        }

        public Teacher GetTeacher(int IdTeacher)
        {
            IEnumerable<Teacher> teachers = db.Teachers;
            foreach (var teacher in teachers)
            {
                if (teacher.IdTeacher == IdTeacher)
                {
                    return teacher;
                }
            }
            return null;
        }

        public int GetTotalTeachersOfSubject(int IdSubject)
        {
            IEnumerable<TeacherSubject> teacherSubjects = db.TeacherSubjects;
            int total = 0;

            foreach (var teacherSubject in teacherSubjects)
            {
                if (teacherSubject.IdSubject == IdSubject)
                {
                    total++;
                }
            }

            return total;
        }

        public PeriodKind GetPeriodKind(int IdPeriodKind)
        {
            IEnumerable<PeriodKind> kinds = db.PeriodKinds;
            foreach (var kind in kinds)
            {
                if (kind.IdPeriodKind == IdPeriodKind)
                {
                    return kind;
                }
            }   
            return null;
        }

        public int GetTotalHoursGroup(int IdGroup)
        {
            IEnumerable<Assignature> assignatures = db.Assignatures;
            int total = 0;

            foreach (var assignature in assignatures)
            {
                if (assignature.IdGroup == IdGroup)
                {
                    var subject = GetSubject(assignature.IdSubject);
                    total += (subject.PracticalHours + subject.TheoreticalHours);
                }
            }

            return total;
        }

        public int GetTotalTeachersOfGroup(int IdGroup)
        {
            IEnumerable<Assignature> assignatures = db.Assignatures;
            List<Teacher> teachers = new List<Teacher>();

            int total = 0;

            foreach (var assignature in assignatures)
            {
                var teacher = GetTeacher(assignature.IdTeacher);
                if (assignature.IdGroup == IdGroup && !teachers.Contains(teacher))
                {
                    teachers.Add(teacher);
                    total++;
                }
            }

            return total;
        }

        public int GetTotalSubjectsOfGroup(int IdGroup)
        {
            IEnumerable<GroupSubject> groupSubjects = db.GroupSubjects;
            int total = 0;

            foreach (var groupSubject in groupSubjects)
            {
                if (groupSubject.IdGroup == IdGroup)
                {
                    total++;
                }
            }

            return total;
        }

        public bool GetGroupStatus(int IdGroup)
        {
            return (IsGroupSubjectsOk(IdGroup) && IsTeachersOk(IdGroup) && AreClassesOk(IdGroup));

        }

        public bool IsGroupSubjectsOk(int IdGroup)
        {
            int subjects = GetTotalSubjectsOfGroup(IdGroup);
            return (subjects >= MIN_GROUPS_SUBJECTS && subjects <= MAX_GROUP_SUBJECTS);
        }

        public bool IsTeachersOk(int IdGroup)
        {
            int teachers = GetTotalTeachersOfGroup(IdGroup);
            return (teachers >= MIN_GROUP_TEACHERS && teachers <= MAX_GROUP_TEACHERS);
        }

        public bool AreClassesOk(int IdGroup)
        {
            IEnumerable<GroupSubject> groupSubjects = db.GroupSubjects;
            IEnumerable<Assignature> assignatures = db.Assignatures;

            foreach(var groupSubject in groupSubjects)
            {
                bool flag = false;
                foreach (var assignature in assignatures)
                {
                    flag = (assignature.IdGroup == groupSubject.IdGroup && assignature.IdSubject == groupSubject.IdSubject);
                    if (flag)
                    {
                        break;
                    }
                }
                if (!flag)
                {
                    return false;
                }
            }

            return true;
        }

        public List<Assignature> GetTeacherAssignatures(int IdTeacher)
        {
            IEnumerable<Assignature> assignatures = db.Assignatures;
            List<Assignature> teacherAssignatures = new List<Assignature>();

            foreach (var assignature in assignatures)
            {
                if (assignature.IdTeacher == IdTeacher)
                {
                    teacherAssignatures.Add(assignature);
                }
            }

            return teacherAssignatures;
        }
    }
}