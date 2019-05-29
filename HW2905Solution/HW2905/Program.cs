using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2905
{
    class Program
    {
        private static bool DayAppears(DaysOfWeek listOfDays, DaysOfWeek singleDay)
        {
            return listOfDays.HasFlag(singleDay);
        }

        private static DaysOfWeek AddDay(DaysOfWeek listOfDays, DaysOfWeek singleDay)
        {
            return listOfDays | singleDay;
        }

        private static DaysOfWeek RemoveDay(ref DaysOfWeek listOfDays, DaysOfWeek singleDay)
        {
            return listOfDays &~ singleDay;
        }

        private static void PrintDaysWhichDoesNotAppear(DaysOfWeek listOfDays)
        {
            //Array listOfEnums = Enum.GetValues(typeof(DaysOfWeek));

            //Type type = typeof(DaysOfWeek);

            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                if (!listOfDays.HasFlag(day))
                {
                    Console.WriteLine(day);
                }
            }
        }

        static void Main(string[] args)
        {
            DaysOfWeek dotNetCourseDays = DaysOfWeek.Sunday | DaysOfWeek.Wednesday;

            if (DayAppears(dotNetCourseDays, DaysOfWeek.Thursday))
            {
                Console.WriteLine($"dotNetCourseDays contains {DaysOfWeek.Thursday}");
            }
            else
            {
                Console.WriteLine($"dotNetCourseDays DOES NOT contains {DaysOfWeek.Thursday}");
            }

            dotNetCourseDays = AddDay(dotNetCourseDays, DaysOfWeek.Thursday);
            if (DayAppears(dotNetCourseDays, DaysOfWeek.Thursday))
            {
                Console.WriteLine($"dotNetCourseDays contains {DaysOfWeek.Thursday}");
            }

            PrintDaysWhichDoesNotAppear(dotNetCourseDays);
        }
    }
}
