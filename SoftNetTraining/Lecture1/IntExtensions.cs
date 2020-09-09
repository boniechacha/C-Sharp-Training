using System;

namespace SoftNetTraining
{
    public static class IntExtensions
    {
        public static bool isLessThan100(this int input)
        {
            return input < 100;
        }

        public static bool isGreateThan0(this int input)
        {
            return input > 0;
        }

        public static int toInt(this string input)
        {
            return Convert.ToInt32(input);
        }
        
        
    }
}