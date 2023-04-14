using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using DataBaseClassLibrary.DTOs;

namespace ClassLibrary.Models
{
    public class Class
    {
        DataBaseClassLibrary.DatabaseHelpers.ClassDatabaseHelper dbHelper = new DataBaseClassLibrary.DatabaseHelpers.ClassDatabaseHelper();
        UserMapper userMapper = new UserMapper();
        ClassMapper classMapper = new ClassMapper();

        private int _nameClass;
        private int _teacherIdClass;

        private List<Student> _students = new List<Student>() {}; //TODO

        public int Name { get { return _nameClass; } }
        public int TeacherID { get { return this._teacherIdClass; } }
        public List<Student> Students { get { return this._students; } }

        public Class(int name, int teacherid)
        {
            //to load and write
            //classManager = new ClassManager();
            this._nameClass = name;
            this._teacherIdClass = teacherid;
        }
        //public Class(int name, int teacherid, List<Student> students)
        //{
        //    //classManager = new ClassManager();
        //    this._nameClass = name;
        //    this._teacherIdClass = teacherid;
        //    this._students = students;
        //}

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
                students.Add((Student)userMapper.MapStudentDTOtoStudent(studentDTO));
            }
            return students;
        }
        public bool Create()
        {
            Class currentClass = new Class(this._nameClass, this._teacherIdClass);

            if (dbHelper.CreateClass(classMapper.MapClassToClassDTO(currentClass)))
            {
                return true;
            }
            return false;
        }
    }
}
