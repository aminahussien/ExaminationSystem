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
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Exam Time in Minutes: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numQuestions = int.Parse(Console.ReadLine());

            List<Question> questions = new List<Question>();

            for (int i = 0; i < numQuestions; i++)
            {
                Console.Clear();
                int qType = 1; 

                if (examType == 2) 
                {
                    Console.Write($"Question {i + 1} Type (1 for MCQ, 2 for True/False): ");
                    qType = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                decimal mark = decimal.Parse(Console.ReadLine());

                if (qType == 1) 
                {
                    List<Answer> answers = new List<Answer>();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter Answer Option {j + 1}: ");
                        answers.Add(new Answer(j + 1, Console.ReadLine()));
                    }

                    McqQuestion mcq = new McqQuestion("MCQ Question", body, mark, answers);

                    Console.Write("Enter Right Answer ID: ");
                    int rightId = int.Parse(Console.ReadLine());
                    mcq.RightAnswer = answers.Find(a => a.AnswerId == rightId);

                    questions.Add(mcq);
                }
                else 
                {
                    TrueOrFalseQuestion tf = new TrueOrFalseQuestion("True/False Question", body, mark);

                    Console.Write("Enter Right Answer ID (1 for True, 2 for False): ");
                    int rightId = int.Parse(Console.ReadLine());
                    tf.RightAnswer = tf.AnswerList.Find(a => a.AnswerId == rightId);

                    questions.Add(tf);
                }
            }
            if (examType == 1)
                ExamOfTheSubject = new PracticalExam(time, numQuestions, questions);
            else
                ExamOfTheSubject = new FinalExam(time, numQuestions, questions);
        }
    }
}
