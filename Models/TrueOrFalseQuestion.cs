namespace ExaminationSystem.Models
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string header, string body, decimal mark) : base(header, body, mark)
        {
            AnswerList = new List<Answer>
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
        }

        public override void CreateQuestion()
        {
            Console.WriteLine(ToString());
            foreach (var ans in AnswerList)
            {
                Console.WriteLine(ans);
            }
        }
    }
}
