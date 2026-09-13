using ExaminationSystem.Contracts;
namespace ExaminationSystem.Models
{
    public class FinalExam : Exam 
    {
        public TrueOrFalseQuestion TrueOrFalseQuestion { get; set; }
        public McqQuestion McqQuestion { get; set; }


        public override void ShowTheExam()
        {
            throw new NotImplementedException();
        }
    }
}
