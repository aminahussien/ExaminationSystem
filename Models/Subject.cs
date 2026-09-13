namespace ExaminationSystem.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam ExamOfTheSubject { get; set; }
        public Subject(int subjectId , string subjectName) {
            SubjectId= subjectId ;
            SubjectName= subjectName ;
        }

        //implement the functionality to create an exam 
        public void CreateAnExam()
        {
            Console.WriteLine("Enter the type of the Exam (1 for Practical , 2 for Final)");


        }
    }
}
