using ExaminationSystem.Contracts;
namespace ExaminationSystem.Models
{
    public class FinalExam : Exam 
    {
        public FinalExam(int time , int numOfQuestions, List<Question> questions):base(time, numOfQuestions, questions) { }
        public override void ShowTheExam()
        {
            stopwatch.Start();

            decimal totalGrade = 0;
            decimal totalPossibleMarks = 0;

            Console.WriteLine("================ Final Exam ================");

            for (int i = 0; i < Questions.Count; i++)
            {
                totalPossibleMarks += Questions[i].Mark;

                Console.WriteLine($"\nQuestion ({i + 1}):");
                Questions[i].CreateQuestion();

                int userChoiceId;
                do
                {
                    Console.Write("Your Answer ID: ");
                } while (!int.TryParse(Console.ReadLine(), out userChoiceId));

                Questions[i].UserAnswer = Questions[i].AnswerList.Find(a => a.AnswerId == userChoiceId);

                if (Questions[i].UserAnswer != null &&
                    Questions[i].UserAnswer.AnswerId == Questions[i].RightAnswer.AnswerId)
                {
                    totalGrade += Questions[i].Mark;
                }
            }

            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("================ Final Exam Results ================");
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Your Answer: {Questions[i].UserAnswer?.AnswerText ?? "No Answer"}");
                Console.WriteLine($"Right Answer: {Questions[i].RightAnswer.AnswerText}");
            }

            Console.WriteLine($"Your Grade: {totalGrade} / {totalPossibleMarks}");
            Console.WriteLine($"Total Time Elapsed: {stopwatch.Elapsed:mm\\:ss}");
        }
    }
}
