namespace SoftNetTraining.Lecture2
{
    public class AttendanceReport:IPrintable
    {
        private string content;

        public AttendanceReport(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }
    }
}