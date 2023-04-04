using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using DataBaseClassLibrary.DTOs;

namespace ClassLibrary.Models
{
    public class Class
    {
        DataBaseClassLibrary.DatabaseHelpers.ClassDatabaseHelper dbHelper = new DataBaseClassLibrary.DatabaseHelpers.ClassDatabaseHelper();
        UserMapper mapper = new UserMapper();

        private int _nameClass;
        private int _teacherIdClass;
        private List<Student> _students = new List<Student>() {}; //TODO

        //private ClassManager classManager;

        public int Name { get { return _nameClass; } }
        public int TeacherID { get { return this._teacherIdClass; } }
        public List<Student> Students { get { return this._students; } }

        public Class(int name) 
        {
            //classManager = new ClassManager();
            this._nameClass = name;
        }
        public Class(int name, int teacherid)
        {
            //classManager = new ClassManager();
            this._nameClass = name;
            this._teacherIdClass = teacherid;
        }

        public void ChangeTeacher(int newTeacherId)
        {
            this._teacherIdClass = newTeacherId;
            //ADD LOGIC
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            foreach (StudentDTO studentDTO in dbHelper.GetClassStudentsFromDB(this._nameClass))
            {
                students.Add((Student)mapper.MapStudentDTOtoStudent(studentDTO));
            }
            return students;
        }

        //public List<int> GetStudentsIds() { return studentsIds; }//TODO
        //internal List<Student> GetStudents()
        //{
        //    return Students; 
        //}
    }
}
