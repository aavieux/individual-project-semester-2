namespace RazorPagesProject.Models
{
    public class Class
    {
        private int _nameClass;
        private int? _teacherIdClass;
        private List<int> studentsIds = new List<int>() {123};

        public int Name { get { return _nameClass; } set { this._nameClass = value; } }
        public int? TeacherID { get { return this._teacherIdClass; } set { this._teacherIdClass = value; } }

        public Class(int name) 
        {
            this._nameClass = name;
        }
        public Class(int name, int teacherid)
        {
            this._nameClass = name;
            this._teacherIdClass = teacherid;
        }
        public List<int> GetStudentsIds() { return studentsIds; }
        public void ChangeTeacher(int newTeacherID) 
        {
            foreach (Teacher teacher in Administration.GetTeachersFromLocal())
            {
                if (teacher.Userid == newTeacherID && teacher.Class == null) // if the teacher exist and it has no class
                {
                    _teacherIdClass = teacher.Userid;
                    teacher.Class = this._nameClass;
                    return;
                }
                else if (teacher.Userid == newTeacherID && teacher.Class != null)// if the teacher exist and it HAS ALREADY class
                {
                    if (teacher.Class != this._nameClass)
                    {
                        _teacherIdClass = teacher.Userid;
                        Administration.GetClassFromLocal((int)teacher.Class)._teacherIdClass = null;
                        teacher.Class = this._nameClass;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("This teacher has already been assigned to this class!");
                    }
                }
            }
            Console.WriteLine("No such UserID was found!");
        }
    }
}
