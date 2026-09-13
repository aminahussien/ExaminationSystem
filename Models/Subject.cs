namespace ExaminationSystem.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam ExamOfTheSubject { get; set; }

        //implement the functionality to create an exam 
        public void CreateAnExam()
        {

        }
    }
}
