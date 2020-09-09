namespace SoftNetTraining.Payroll
{
    public class Allowance : ISalaryInput
    {
        private double percentage;

        public double CalculateAmount(double basicAmount)
        {
            return basicAmount * percentage;
        }
    }
}