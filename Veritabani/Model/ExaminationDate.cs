using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritabani.Model
{
    public class ExaminationDate
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public DateTime ExamDate { get; set; }

    }
}
