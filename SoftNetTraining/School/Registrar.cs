using System;

namespace SoftNetTraining.School
{
    public class Registrar
    {
        private static Registrar _registrar;

        public event EventHandler<StudentArgs> OnRegistration;

        private Registrar()
        {
        }

        public static Registrar getInstance()
        {
            if (_registrar == null)
            {
                _registrar = new Registrar();
            }

            return _registrar;
        }

        public void Register(Student student)
        {
            Console.WriteLine("Registering student");

            StudentArgs args = new StudentArgs(student);
            OnRegistration(this, args);
        }
    }
}