using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string StudentIdNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int LoginType { get; set; }

    }
}
