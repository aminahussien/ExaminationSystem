namespace ExaminationSystem.Models
{
    public class McqQuestion : Question
    {
        public McqQuestion(string header, string body, decimal mark, List<Answer> answers) : base(header, body, mark)
        {
            AnswerList = answers;
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
