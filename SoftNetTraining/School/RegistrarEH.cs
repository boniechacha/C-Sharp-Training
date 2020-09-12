using System;

namespace SoftNetTraining.School
{
    public class RegistrarEH
    {
        private static RegistrarEH _registrar;

        public event Action<Student> OnRegistration = (student) =>{};
        
        private RegistrarEH()
        {
        }

        public static RegistrarEH getInstance()
        {
            if (_registrar == null)
            {
                _registrar = new RegistrarEH();
            }

            return _registrar;
        }

        public void Register(Student student)
        {
            Console.WriteLine("Registering student");
            OnRegistration(student);
        }
    }
}