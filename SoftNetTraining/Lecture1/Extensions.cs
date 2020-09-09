namespace SoftNetTraining
{
    public static class Extensions
    {
        public static bool isFirstCap(this string input)
        {
            return !string.IsNullOrEmpty(input) && char.IsUpper(input[0]);
        }

    }
}