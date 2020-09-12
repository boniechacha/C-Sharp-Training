namespace SoftNetTraining.School
{
    public class School
    {
        public static void Run()
        {
            Student student = new Student("123", "Chacha", "CS", "Posta");

            Registrar registrar = Registrar.getInstance();
            registrar.Register(student);
        }
    }
}