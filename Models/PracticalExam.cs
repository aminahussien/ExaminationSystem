using ExaminationSystem.Contracts;
namespace ExaminationSystem.Models
{
    public class PracticalExam : Exam
    {
        public McqQuestion McqQuestion { get; set; }

        public override void ShowTheExam()
        {
            throw new NotImplementedException();
        }
    }
}
