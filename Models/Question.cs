

namespace ExaminationSystem.Models
{
    public class Question
    {
        public Question(string header, string body, decimal mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public string Header { get; set ; }
        public string Body { get; set; }
        public decimal Mark { get; set; }

        public Answer[] AnswerList { get; set; }


    }
}
