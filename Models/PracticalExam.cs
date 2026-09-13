using ExaminationSystem.Contracts;
namespace ExaminationSystem.Models
{
    public class PracticalExam : Exam
    {
        //public McqQuestion McqQuestion { get; set; }
        public List<McqQuestion> mcqQuestions = new List<McqQuestion>();
         public PracticalExam(int time , int numOfQuestions) : base (time , numOfQuestions) { }
        public override void ShowTheExam()
        {
            throw new NotImplementedException();
        }
    }
}
