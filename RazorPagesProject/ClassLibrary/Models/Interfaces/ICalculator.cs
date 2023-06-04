using ClassLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Interfaces
{
    public interface ICalculator
    {
        public string GetAvgGradeForSubject(Subject subject);
        public List<Student> GetBestStudents(int number);

    }
}
