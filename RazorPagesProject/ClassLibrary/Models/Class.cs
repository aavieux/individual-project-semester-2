using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;

namespace ClassLibrary.Models
{
    public class Class
    {
        ClassDatabaseHelper classDbHelper;
        UserDatabaseHelper userDbHelper;
        GradeDatabaseHelper gradeDbHelper;

        UserMapper userMapper;
        ClassMapper classMapper;

        private int _nameClass;
        private int _teacherIdClass;

        private List<Student> _students = new List<Student>() {}; //TODO

        public int Name { get { return _nameClass; } }
        public int TeacherID { get { return this._teacherIdClass; } }
        public List<Student> Students { get { return this._students; } }

        public Class(
            ClassDatabaseHelper classDbHelper, 
            UserDatabaseHelper userDbHelper, 
            GradeDatabaseHelper gradeDbHelper, 
            int name, 
            int teacherid)
        {
            //to load and write
            //classManager = new ClassManager();
            
            this._nameClass = name;
            this._teacherIdClass = teacherid;

            this.classDbHelper = classDbHelper;
            this.userDbHelper = userDbHelper;
            this.gradeDbHelper = gradeDbHelper;

            this.userMapper = new UserMapper(userDbHelper,gradeDbHelper);
            this.classMapper = new ClassMapper(classDbHelper, userDbHelper, gradeDbHelper);
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
            foreach (StudentDTO studentDTO in classDbHelper.GetClassStudentsFromDB(this._nameClass))
            {
                students.Add((Student)userMapper.MapStudentDTOtoStudent(studentDTO));
            }
            return students;
        }
        public bool Create()
        {
            Class currentClass = new Class(classDbHelper,userDbHelper,gradeDbHelper,this._nameClass, this._teacherIdClass);

            if (classDbHelper.CreateClass(classMapper.MapClassToClassDTO(currentClass)))
            {
                return true;
            }
            return false;
        }
    }
}
