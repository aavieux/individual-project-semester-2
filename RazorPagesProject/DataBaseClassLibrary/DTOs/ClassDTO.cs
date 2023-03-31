using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    internal class ClassDTO
    {
        private readonly int _name;
        private readonly int _teacherID;
        private readonly List<StudentDTO> _students;

        public int Name { get { return _name; } }
        public int TeacherID { get { return _teacherID; } }
        public List<StudentDTO> Students { get { return _students; } }

        public ClassDTO(int name, int teacherID, List<StudentDTO> students)
        {
            _name = name;
            _teacherID = teacherID;
            _students = students;
        }
    }
}
