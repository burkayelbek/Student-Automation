using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritabani.Model
{
    public class Absenteeism
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime DayOfAbsenteeism { get; set; }


    }
}
