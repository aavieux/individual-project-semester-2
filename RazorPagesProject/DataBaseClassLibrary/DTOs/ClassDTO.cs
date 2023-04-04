using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    public class ClassDTO
    {
        private readonly int _name;
        private readonly int _teacherID;
        private readonly List<StudentDTO> _students;

        public int Name { get { return this._name; } }
        public int TeacherID { get { return this._teacherID; } }
        public ClassDTO(int name, int teacherID, List<StudentDTO> students)
        {
            _name = name;
            _teacherID = teacherID;
            _students = students;
        }
        public ClassDTO(int name, int teacherID)
        {
            _name = name;
            _teacherID=teacherID;
        }
    }
}
