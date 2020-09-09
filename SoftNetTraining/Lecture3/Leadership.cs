using System.Collections;
using System.Collections.Generic;

namespace SoftNetTraining.Lecture3
{
    public class Leadership : IEnumerable<string>
    {
        public string Chairman { get; set; }
        public string ViceChairman { get; set; }
        public string Secretary { get; set; }
        public string Treasurer { get; set; }

        public Leadership(string chairman, string viceChairman, string secretary, string treasurer)
        {
            this.Chairman = chairman;
            this.ViceChairman = viceChairman;
            this.Secretary = secretary;
            this.Treasurer = treasurer;
        }

        public IEnumerator<string> GetEnumerator()
        {
            yield return Chairman;
            yield return ViceChairman;
            yield return Secretary;
            yield return Treasurer;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}