using ExaminationSystem.Contracts;
namespace ExaminationSystem.Models
{
    public class FinalExam : Exam 
    {
       // public TrueOrFalseQuestion TrueOrFalseQuestion { get; set; }
        //public McqQuestion McqQuestion { get; set; }

        public List<TrueOrFalseQuestion> TrueOrFalseQuestions = new List<TrueOrFalseQuestion>();
        public List<McqQuestion> mcqQuestions = new List<McqQuestion>();
        public FinalExam(int time , int numOfQuestions):base(time, numOfQuestions) { }
        public override void ShowTheExam()
        {
            throw new NotImplementedException();
        }
    }
}
