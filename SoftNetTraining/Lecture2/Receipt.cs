namespace SoftNetTraining.Lecture2
{
    public class Receipt:IPrintable
    {
        private int amount;

        public Receipt(int amount)
        {
            this.amount = amount;
        }

        public string GetContent()
        {
            return "Receipt:" + amount;
        }
    }
}