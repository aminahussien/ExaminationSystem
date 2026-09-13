namespace ExaminationSystem.Models
{
    public abstract class Question : ICloneable ,IComparable<Question>
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
        public List<Answer> AnswerList { get; set; } = new List<Answer>();
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }

        public abstract void CreateQuestion();
        public override string ToString()
        {
            return $"{Header}\tMark: ({Mark})\n{Body}";
        }
        public int CompareTo(Question other)
        {
            if (other == null) return 1;
            return Mark.CompareTo(other.Mark);
        }

        public virtual object Clone()
        {
            Question cloned = (Question)this.MemberwiseClone();

            // Deep copy of the List<Answer>
            cloned.AnswerList = new List<Answer>();
            foreach (var ans in this.AnswerList)
            {
                cloned.AnswerList.Add((Answer)ans.Clone());
            }

            if (RightAnswer != null) cloned.RightAnswer = (Answer)RightAnswer.Clone();
            if (UserAnswer != null) cloned.UserAnswer = (Answer)UserAnswer.Clone();

            return cloned;
        }
    }
}
