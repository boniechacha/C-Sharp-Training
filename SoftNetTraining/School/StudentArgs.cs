using System;

namespace SoftNetTraining.School
{
    public class StudentArgs : EventArgs
    {
        public Student Student { get; }

        public StudentArgs(Student student)
        {
            Student = student;
        }
    }
}