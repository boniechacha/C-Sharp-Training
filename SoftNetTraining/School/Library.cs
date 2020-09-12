namespace SoftNetTraining.School
{
    public class Library
    {
        public Library()
        {
            Registrar registrar = Registrar.getInstance();
            registrar.OnRegistration += SubscribeNewsLetter;
        }

        public void SubscribeNewsLetter(Student student)
        {
        }
        
        public void SubscribeNewsLetter(object sender,StudentArgs student)
        {
        }
    }
}