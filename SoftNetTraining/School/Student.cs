namespace SoftNetTraining.School
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string Campus { get; set; }

        public Student(string id, string name, string course, string campus)
        {
            Id = id;
            Name = name;
            Course = course;
            Campus = campus;
        }
    }
}