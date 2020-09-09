namespace SoftNetTraining.Lecture2
{
    public class Report : IDisplay, IPrint
    {

        string IDisplay.getContent()
        {
            return "Report content to display";
        }
        string IPrint.getContent()
        {
            return "Report content to print";
        }
        
        
        // public string getContent()
        // {
        //     return "Report Contents";
        // }
    }
}