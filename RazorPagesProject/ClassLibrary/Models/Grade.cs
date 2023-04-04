using ClassLibrary.Models.Enums;

namespace ClassLibrary.Models
{
    public class Grade
    {
        private int _idGrade;
        private int _idSubjectGrades;
        private GradeEnum _grade;
            
        public int IdGrade { get { return _idGrade; }}
        public int IdSubjectGrades { get { return _idSubjectGrades; }}
        public GradeEnum GradeEnum { get { return _grade; }}

        public Grade(int idGrade ,int idSubjectGrades, GradeEnum grade) 
        {
            this._idGrade = idGrade;
            this._idSubjectGrades = idSubjectGrades;
            this._grade = grade;
        }
		public Grade(GradeEnum grade)
		{
			this._grade = grade;
		}
		//public Grade(int idGrade,int idSubjectGrades,GradeEnum grade)
		//{
		//          this._idGrade = idGrade;
		//          this._idSubjectGrades = idSubjectGrades;
		//          this._grade = grade;
		//}
	}
}
