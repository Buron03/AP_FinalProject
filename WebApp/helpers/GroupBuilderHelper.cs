using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using System.Linq;
using AppContext;
using AppContext.Models;
using static AppContext.Const.Constant;

namespace WebApp.Helpers
{
    public class GroupBuilderHelper
    {

        private School db;

        public GroupBuilderHelper(School db)
        {
            this.db = db;
        }

        public DateTime RoundDate(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                date = date.AddDays(2);
            }
            else if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                date = date.AddDays(1);
            }

            return date;
        }

        public string CreateName()
        {
            string letter = "";
            string number = "";

            do
            {
                letter = ((char) (new Random()).Next(65, 80)).ToString();
                number = (new Random()).Next(1, 10).ToString();
            } while (!IsAvailableName(letter+number));
            

            return (letter + number);
        }

        public bool IsAvailableName(string name)
        {
            var groups = db.SchoolGroups;
            foreach (var group in groups)
            {
                if (group.Name == name)
                {
                    return false;
                }
            }
            return true;
        }
    }
}