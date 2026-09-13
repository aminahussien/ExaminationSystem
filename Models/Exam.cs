namespace ExaminationSystem.Models
{
    public abstract class Exam
    {
        public TimeOnly Time {  get; set; }
        public static int NumberOfQuestions { get; set; }

        public Question[] ExamQuestions = new Question[NumberOfQuestions];

        public Subject SubjectName { get; set; }

        //show exam functionality 
        public abstract void ShowTheExam();
        
    }
}
