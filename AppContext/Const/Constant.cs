using System;

namespace AppContext.Const
{
    public static class Constant
    {
        //Teacher const
        public const int MAX_GROUPS = 5;
        public const int MIN_GROUPS = 1; 
        public const int MAX_SUBJECTS = 5;
        public const int MIN_SUBJECTS = 1;

        //Group const
        public const int MAX_GROUP_SUBJECTS = 10;
        public const int MIN_GROUPS_SUBJECTS = 5;
        public const int MAX_GROUP_TEACHERS = 10;
        public const int MIN_GROUP_TEACHERS = 3;

        //Subject const
        public const int MAX_THEORETICAL_HOURS = 5;
        public const int MAX_PRACTICAL_HOURS = 5;
        public const int MIN_THEORETICAL_HOURS = 0;
        public const int MIN_PRACTICAL_HOURS = 0;
    }
}