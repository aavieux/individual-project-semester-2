using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    public class ClassDTO
    {
        private int _name;
        private int _teacherID;
        private List<StudentDTO> _students;

        public int Name { get { return _name; } }
        public int TeacherID { get { return _teacherID; } }
        public List<StudentDTO> Students { get { return _students; } }

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
