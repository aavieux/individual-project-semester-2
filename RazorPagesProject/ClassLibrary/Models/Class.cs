using ClassLibrary.Controllers;

namespace ClassLibrary.Models
{
    public class Class
    {
        private int _nameClass;
        private int _teacherIdClass;
        private List<Student> _students = new List<Student>() {}; //TODO

        //private ClassManager classManager;

        public int Name { get { return _nameClass; } set { this._nameClass = value; } }
        public int TeacherID { get { return this._teacherIdClass; } set { this._teacherIdClass = value; } }
        public List<Student> Students { get { return this._students; }set { this._students = value; } }

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

        //public List<int> GetStudentsIds() { return studentsIds; }//TODO
        //internal List<Student> GetStudents()
        //{
        //    return Students; 
        //}
    }
}
