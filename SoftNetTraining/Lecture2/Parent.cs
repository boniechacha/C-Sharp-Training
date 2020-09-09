namespace SoftNetTraining.Lecture2
{
    public class Parent
    {
        private int parentData;

        public Parent(int parentData)
        {
            this.parentData = parentData;
        }

        public Parent(int parentData, int x)
        {
        }
    }

    public class Child : Parent
    {
        private int childData;

        public Child(int parentData) : base(parentData)
        {
        }
    }
}