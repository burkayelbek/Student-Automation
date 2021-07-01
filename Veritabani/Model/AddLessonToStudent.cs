using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritabani.Model
{
    public class AddLessonToStudent
    {
        public int Id { get; set; }

        public int LessonID { get; set; }
        public string LessonName { get; set; }
        public int StudentID{ get; set; }
        public string StudentName { get; set; }
    }
}
