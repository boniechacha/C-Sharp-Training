namespace SoftNetTraining.Payroll
{
    public class Deduction : ISalaryInput
    {
        private double percentage;
        public string Name { get; set; }

        public double CalculateAmount(double basicAmount)
        {
            return -1 * basicAmount * percentage;
        }
    }
}