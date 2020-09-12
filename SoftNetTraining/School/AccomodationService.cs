namespace SoftNetTraining.School
{
    public class AccomodationService
    {
        public AccomodationService()
        {
            Registrar registrar = Registrar.getInstance();
            registrar.OnRegistration += PrepareRoom;
        }

        public void PrepareRoom(Student student)
        {
        }

        public void PrepareRoom(object sender, StudentArgs student)
        {
        }
    }
}