using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class Exam
    {
        public TimeOnly Time {  get; set; }
        public int NumberOfQuestions { get; set; }

        public Subject SubjectName { get; set; }

        //show exam functionality 
        public void virtual MakeAnExam()
        {

        }
    }
}
