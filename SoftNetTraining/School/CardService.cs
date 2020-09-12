using System;

namespace SoftNetTraining.School
{
    public class CardService
    {
        public CardService()
        {
            Registrar registrar = Registrar.getInstance();
            registrar.OnRegistration += PrintCard;
        }

        public void PrintCard(Student student)
        {
            Console.WriteLine("Printing card ...");
        }

        public void PrintCard(object sender, StudentArgs ars)
        {
            Student student = ars.Student;
            Console.WriteLine("Printing card ...");
        }
    }
}