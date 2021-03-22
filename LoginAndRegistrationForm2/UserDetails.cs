using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndRegistrationForm2
{
    static class UserDetails
    {
        public static bool doneSetTimetable = false;

        public static int userID;
        public static string userName; //Once assigned, static variables will be there for the rest of the program
        

        public static string[] breakfastOptions;
        public static string[] lunchOptions;
        public static string[] dinnerOptions;

        public static decimal change = 0;
       
    }
}
