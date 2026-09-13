using ExaminationSystem.Models;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10, "Object Oriented Programming");

            Console.WriteLine($"Creating Exam for Subject: {subject.SubjectName}\n");
            subject.CreateAnExam();

            Console.Clear();
            Console.Write("Do you want to start the exam? (Y/N): ");
            char choice = char.Parse(Console.ReadLine());

            if (choice == 'Y' || choice == 'y')
            {
                Console.Clear();
                subject.ExamOfTheSubject.ShowTheExam();
            }
            else
            {
                Console.WriteLine("Exam cancelled.");
            }
        }
    }
}
