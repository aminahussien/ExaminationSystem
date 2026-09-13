namespace ExaminationSystem.Models
{
    public class McqQuestion : Question
    {
        public McqQuestion(string header, string body, decimal mark) : base(header, body, mark)
        {
        }

        protected override void CreateQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
