namespace RazorPagesProject.Models
{
    public class Class
    {
        private int name;
        private int? teacherid;
        private List<int> studentsIds;

        public int Name { get { return name; } set { this.name = value; } }
        public int? TeacherID { get { return this.teacherid; } set { this.teacherid = value; } }

        public Class(int name) 
        {
            this.name = name;
        }
        public Class(int name, int teacherid)
        {
            this.name = name;
            this.teacherid = teacherid;
        }
        public List<int> GetStudentsIds() { return studentsIds; }
        public void ChangeTeacher(int newTeacherID) 
        {
            foreach (Teacher teacher in Administration.GetTeachersFromLocal())
            {
                if (teacher.Userid == newTeacherID && teacher.Class == null) // if the teacher exist and it has no class
                {
                    teacherid = teacher.Userid;
                    teacher.Class = this.name;
                    return;
                }
                else if (teacher.Userid == newTeacherID && teacher.Class != null)// if the teacher exist and it HAS ALREADY class
                {
                    if (teacher.Class != this.name)
                    {
                        teacherid = teacher.Userid;
                        Administration.GetClassFromLocal((int)teacher.Class).teacherid = null;
                        teacher.Class = this.name;
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
