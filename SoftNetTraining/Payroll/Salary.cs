using System.Collections.Generic;

namespace SoftNetTraining.Payroll
{
    public class Salary
    {
        private double basicAmount;
        private List<ISalaryInput> inputs = new List<ISalaryInput>();

        public double CalculateTakeHome()
        {
            double takeHome = 0;
            takeHome = takeHome + basicAmount;

            foreach (ISalaryInput input in inputs)
            {
                double inputAmount = input.CalculateAmount(basicAmount);
                takeHome = takeHome + inputAmount;
            }

            return takeHome;
        }
    }
}