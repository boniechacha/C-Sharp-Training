using System;
using System.Collections.Generic;

namespace SoftNetTraining.Payroll
{
    public class PayrollProgram
    {
        public static void Run()
        {
            List<Deduction> deductions = new List<Deduction>();

            Deduction d1 = new Deduction();
            d1.Name = "NHIF";
            Console.WriteLine(d1.Name);
            
            Deduction d2 = new Deduction();
            d2.Name = "NSSF";
            
            Deduction d3 = new Deduction();
            d3.Name = "HESLB";

            deductions.Add(d1);
            deductions.Add(d2);
            deductions.Add(d3);
            
            
        }
    }
}