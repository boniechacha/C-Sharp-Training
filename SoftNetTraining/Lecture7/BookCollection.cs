using System.Runtime.Serialization;

namespace SoftNetTraining.Lecture7
{
    [DataContract]
    public class BookCollection
    {

        [DataMember]
        public Book[] Books { get; set; }
    }
}