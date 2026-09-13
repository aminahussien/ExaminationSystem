using System.Diagnostics;

namespace ExaminationSystem.Models
{
    public abstract class Exam
    {
        public int Time {  get; set; }
        public static int NumberOfQuestions { get; set; }

        public List<Question> Questions { get; set; }= new List<Question>();    

        public Subject SubjectName { get; set; }

        protected readonly Stopwatch stopwatch = new Stopwatch();   

        protected Exam(int time , int numOfQestions) {
            Time = time;
            Questions = new List<Question>();
        }    
        //show exam functionality 
        public abstract void ShowTheExam();
        
    }
}
