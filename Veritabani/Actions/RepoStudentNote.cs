using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veritabani.Model;

namespace Veritabani.Actions
{
    public class RepoStudentNote
    {
        public string LessonName { get; set; }
        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
        public int Homework { get; set; }
    }
}
