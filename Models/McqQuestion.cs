using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class McqQuestion : Question
    {
        public McqQuestion(string header, string body, decimal mark) : base(header, body, mark)
        {
        }
    }
}
