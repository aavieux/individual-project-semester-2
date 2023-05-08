using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;

namespace ClassLibrary.Models
{
    public class Student : User
    {

        private GradeDatabaseHelper gradeDbHelper;
        private GradeMapper gradeMapper;

        //UserManager userManager;
        //GradeManager gradeManager;

        public Student(UserDatabaseHelper userDbHelper, GradeDatabaseHelper gradeDbHelper, string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber, int UserID) : base(userDbHelper, gradeDbHelper, FirstName, LastName, Role, Class, Email, PhoneNumber, UserID)
        {
            this.gradeDbHelper = gradeDbHelper;
            this.gradeMapper = new GradeMapper(gradeDbHelper);
            //to load
        }
        public Student(UserDatabaseHelper dbHelper, GradeDatabaseHelper gradeDbHelper, string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber) : base(dbHelper, gradeDbHelper, FirstName, LastName, Role, Class, Email, PhoneNumber)
        {
            this.gradeDbHelper = gradeDbHelper;
            this.gradeMapper = new GradeMapper(gradeDbHelper);
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
                subjectGrades.GetGrades();
            }
            return gradebook;
        }

        //MANAGE SUBJECTGRADES
        public void AddEmptySubjectGrades(SubjectGrades subjectGrades)
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
        public bool DeleteSubjectGradesWithGrades(SubjectGrades subjectGrades) // one subject Grade
        {
            try
            {
				if (gradeDbHelper.DeleteSubjectGradesFromDB(gradeMapper.MapSubjectGradestoSubjectGradesDTO(subjectGrades))
                    && DeleteAllGradesFromSubjectGrades(subjectGrades))

				{
					return true;
				}
                return false;
				
			}
            catch (Exception ex)
            {
				return false;
			}
            
        }
		public bool DeleteAllSubjectGradesWithGrades() //all Subject grades
        {
			try
			{
                if (DeleteAllGradesForStudent())
                {
                    foreach (SubjectGrades subjectGrades in GetGradeBook())
                    {
                        if (DeleteSubjectGradesWithGrades(subjectGrades)) { }
                        else
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else return false;
                

				
			}
			catch (Exception)
			{
				return false;
			}
		}

        //MANAGE GRADES
        public bool DeleteAllGradesFromSubjectGrades(SubjectGrades subjectGrades)
        {
            try 
            {
                foreach (Grade grade in subjectGrades.GetGrades())
                {
                    DeleteGradeById(grade.IdGrade);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
		public bool DeleteAllGradesForStudent()
        {
            try
            {
				foreach (SubjectGrades subjectGrades in GetGradeBook())
				{
					foreach (Grade grade in subjectGrades.GetGrades())
					{
						DeleteGradeById(grade.IdGrade);
					}
				}
                return true;
			}
            catch (Exception)
            {
                return false;
            }
            
            
        }
        public void AddGrade(int idSubjectGrades, Grade grade)//USE STUDENT.ADDGRADE TO ADD TO DATABASE, USE SUBJECTGRADES.ADDGRADE TO ADD LOCALLY
        {
            gradeDbHelper.AddGradeToDB(idSubjectGrades, gradeMapper.MapGradeToGradeDTO(grade));
            Console.WriteLine($"Successfully added Grade with id:{grade.GradeEnum} into SubjectGrades with id: {idSubjectGrades}");
        }
        public void DeleteGradeById(int gradeId)
        {
            gradeDbHelper.DeleteGradeByIdFromDB(gradeId);
            Console.WriteLine($"Successfully deleted Grade with id:{gradeId}");
        }
        public double GetAvgGrades()
        {
            double result = 0.0;
            int numberOfGrades = 0;

            foreach (SubjectGrades subjectGrades in GetGradeBook())
            {
                foreach (Grade grade in subjectGrades.GetGrades())
                {
                    if (grade.GradeEnum == GradeEnum.UNDEFINED)
                    {
                        result += 1;
                    }
                    else if (grade.GradeEnum == GradeEnum.SUFFICIENT)
                    {
                        result += 2;
                    }
                    else if (grade.GradeEnum == GradeEnum.GOOD)
                    {
                        result += 3;
                    }
                    else if (grade.GradeEnum == GradeEnum.OUTSTANDING)
                    {
                        result += 4;
                    }

                    numberOfGrades++;
                }   
            }
            return result / numberOfGrades;
        }
    }
}
