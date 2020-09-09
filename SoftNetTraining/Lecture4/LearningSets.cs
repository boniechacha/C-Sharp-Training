using System.Collections.Generic;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Lecture4
{
    public class LearningSets
    {
        public static void Run()
        {
            List<int> l = new List<int>() { 1,2,2,4,5,3,4,7,8};
            ConsoleUtil.Display(l);
            HashSet<int> s = new HashSet<int>() { 1,2,2,4,5,3,4,7,8};
            ConsoleUtil.Display(s);
        }
    }
}