using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritabani.Model
{
    public class ExamOperation
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
        public int Homework { get; set; }
        public int LessonId { get; set; }

    }
}
