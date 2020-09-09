namespace SoftNetTraining.Lecture2
{
    public class FinanceReport:IPrintable
    {
        private string report;

        public FinanceReport(string report)
        {
            this.report = report;
        }

        public string GetContent()
        {
            return report;
        }
    }
}