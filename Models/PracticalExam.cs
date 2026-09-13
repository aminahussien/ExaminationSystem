using ExaminationSystem.Contracts;
namespace ExaminationSystem.Models
{
    public class PracticalExam : Exam
    {
         public PracticalExam(int time , int numOfQuestions, List<Question> questions) : base (time , numOfQuestions, questions) { }
        public override void ShowTheExam()
        {
            stopwatch.Start();

            Console.WriteLine("================ Practical Exam ================");

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"\nQuestion ({i + 1}):");
                Questions[i].CreateQuestion();

                int userChoiceId;
                do
                {
                    Console.Write("Your Answer ID: ");
                } while (!int.TryParse(Console.ReadLine(), out userChoiceId));

                Questions[i].UserAnswer = Questions[i].AnswerList.Find(a => a.AnswerId == userChoiceId);
            }

            stopwatch.Stop();

            Console.Clear();
            Console.WriteLine("================ Practical Exam - Correct Answers ================");
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Right Answer: {Questions[i].RightAnswer.AnswerText}");
                //Console.WriteLine(new string('-', 40));
            }

            Console.WriteLine($"Total Time Elapsed: {stopwatch.Elapsed:mm\\:ss}");
        }
    }
}
