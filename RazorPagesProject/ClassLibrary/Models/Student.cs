using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;

namespace ClassLibrary.Models
{
    public class Student : User
    {
        private GradeDatabaseHelper gradeDbHelper = new GradeDatabaseHelper();
        private GradeMapper gradeMapper = new GradeMapper();

        //UserManager userManager;
        //GradeManager gradeManager;

        public Student(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber, int UserID) : base(FirstName, LastName, Role, Class, Email, PhoneNumber, UserID)
        {
            //to load
        }
        public Student(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber) : base(FirstName, LastName, Role, Class, Email, PhoneNumber)
        {
            //to write
        }

        public List<SubjectGrades> GetGradeBook()
        {
            List<SubjectGrades> gradebook = new List<SubjectGrades>();

            foreach (SubjectGradesDTO subjectGradesDTO in gradeDbHelper.GetGradeBooksFromDB())
            {
                if (subjectGradesDTO.IdUser == this.Userid)
                {

                    gradebook.Add(gradeMapper.MapSubjectGradesDTOtoSubjectGrades(subjectGradesDTO));
                }
            }
            foreach (SubjectGrades subjectGrades in gradebook)
            {
                foreach (GradeDTO gradeDTO in gradeDbHelper.GetGradesFromDB())
                {
                    if (subjectGrades.Id == gradeDTO.IdSubjectGrades)
                    {
                        subjectGrades.AddGrade(gradeMapper.MapGradeDTOtoGrade(gradeDTO));//USE STUDENT.ADDGRADE TO ADD TO DATABASE, USE SUBJECTGRADES.ADDGRADE TO ADD LOCALLY
                    }
                }
            }
            return gradebook;
        }
        public void AddSubjectGrades(SubjectGrades subjectGrades)
        {
            if (subjectGrades.IdUser == Userid)
            {
                gradeDbHelper.AddSubjectGradesToDB(gradeMapper.MapSubjectGradestoSubjectGradesDTO(subjectGrades));
                Console.WriteLine($"Successfully added SubjectGrades with id: {subjectGrades.Id}");
            }
            else
            {
                Console.WriteLine("The SubjectGrades Id and userId do not match!");
            }
        }
            
        public bool DeleteSubjectGrades()
        {
            //delete subjectgrades
            //also delete grades
            return false;
        }
        public void AddGrade(int idSubjectGrades, Grade grade)//USE STUDENT.ADDGRADE TO ADD TO DATABASE, USE SUBJECTGRADES.ADDGRADE TO ADD LOCALLY
        {
            gradeDbHelper.AddGradeToDB(idSubjectGrades, gradeMapper.MapGradeToGradeDTO(grade));
            Console.WriteLine($"Successfully added Grade with id:{grade.GradeEnum} into SubjectGrades with id: {idSubjectGrades}");
        }
        public void DeleteGrade(int gradeId)
        {
            gradeDbHelper.DeleteGradeByIdFromDB(gradeId);
            Console.WriteLine($"Successfully deleted Grade with id:{gradeId}");
        }
        
    }
}
