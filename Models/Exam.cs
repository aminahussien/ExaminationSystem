using System.Diagnostics;

namespace ExaminationSystem.Models
{
    public abstract class Exam
    {
        public int Time {  get; set; }
        public static int NumberOfQuestions { get; set; }

        public List<Question> Questions { get; set; }

        public Subject SubjectName { get; set; }

        protected readonly Stopwatch stopwatch = new Stopwatch();   

        protected Exam(int time , int numOfQestions , List<Question> questions) {
            Time = time;
            NumberOfQuestions = numOfQestions;
            Questions = questions;
        }    
        //show exam functionality 
        public abstract void ShowTheExam();
        
    }
}
