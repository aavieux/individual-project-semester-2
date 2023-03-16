using System.Collections.Generic;
using System.Data.SqlClient;
using RazorPagesProject.Models.Enums;

namespace RazorPagesProject.Models
{
    public class Administration
    {
        private static List<User> users = new List<User>();
        private static List<Class> classes = new List<Class>();

        private static List<SubjectGrades> subjectGrades = new List<SubjectGrades>();
        private static List<Grade> grades = new List<Grade>();
        //public Administration() { }
        public static void GenerateUsersFromDataBase()
        {
            using (SqlConnection connection =
                   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                connection.Open();
                string query = "SELECT * FROM Users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                User user;
                                
                                if (Enum.Parse<Role>(reader["role_user"].ToString()).ToString() == "STUDENT")
                                {
                                    Student student = new Student();

                                    //student.GradeBook = tva se pravi v nachaloto na programata

                                    user = student;
                                }
                                else
                                {
                                    user = new Teacher();
                                }
                               
                                user.Firstname = (string)reader["first_name_user"];
                                user.Lastname = (string)reader["last_name_user"];

                                user.Role = Enum.Parse<Role>(reader["role_user"].ToString());
                                try
                                {
                                    user.Class = (int)reader["class_user"];
                                }
                                catch (Exception)
                                {
                                    user.Class = null;
                                }

                                user.Email = (string)reader["email_user"];
                                user.PhoneNumber = (string)reader["phonenumber_user"];
                                user.Userid = (int)reader["id_user"];

                                

                                users.Add(user);
                                
                            }
                        }
                        catch (SqlException xException)
                        {
                            Console.WriteLine("Error loading teachers from database!");
                        }
                        finally
                        {
                            reader.Close();
                            connection.Close();
                        }
                    }
                }
            }
        }
		public static void GenerateClassesFromDataBase()
		{
			using (SqlConnection connection =
				   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
			{
				connection.Open();
				string query = "SELECT * FROM Classes";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						try
						{
							while (reader.Read())
							{
								Class _class = new Class((int)reader["name_class"]);
								try
								{
									_class.TeacherID = (int)reader["teacher_id_class"];
								}
								catch (Exception)
								{
									_class.TeacherID = null;
								}
								classes.Add(_class);
							}
						}
						catch (SqlException xException)
						{
							Console.WriteLine("Error loading teachers from database!");
						}
						finally
						{
							reader.Close();
							connection.Close();
						}
					}
				}
			}
		}
		public static void GenerateGradeBooksFromDataBase()
		{
			using (SqlConnection connection =
				   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
			{
				connection.Open();
				string query = "SELECT * FROM SubjectGrades";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						try
						{
							while (reader.Read())
							{
								SubjectGrades _subjectGrades = new SubjectGrades();
								try
								{
									_subjectGrades.Id = (int)reader["id_subjectGrades"];
									_subjectGrades.Subject = Enum.Parse<Subject>(reader["subject"].ToString());
									_subjectGrades.IdUser = (int)reader["id_user"];

									subjectGrades.Add(_subjectGrades);
								}
								catch (Exception)
								{
									Console.WriteLine("Error getting subjectgrades from database!");
								}
							}
						}
						catch (SqlException xException)
						{
							Console.WriteLine("Error loading subjectgrades from database!");
						}
						finally
						{
							reader.Close();
							connection.Close();
						}
					}
				}
			}
		}
		public static void GenerateGradesFromDataBase()
		{
			using (SqlConnection connection =
				   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
			{
				connection.Open();
				string query = "SELECT * FROM Grades";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						try
						{
							while (reader.Read())
							{
								Grade grade = new Grade();
								try
								{
									grade.IdGrade = (int)reader["id_grade"];
									grade.IdSubjectGrades = (int)reader["id_subjectGrades"];
									grade.GradeEnum = Enum.Parse<GradeEnum>(reader["grade"].ToString());

									grades.Add(grade);
								}
								catch (Exception)
								{
									Console.WriteLine("Error getting grades from database!");
								}
							}
						}
						catch (SqlException xException)
						{
							Console.WriteLine("Error loading grades from database!");
						}
						finally
						{
							reader.Close();
							connection.Close();
						}
					}
				}
			}
		}

		public static void PutGradesInGradeBooksAndThenInStudents()
		{
			foreach (Grade grade in grades)
			{
				if (GetSubjectGradesById(grade.IdSubjectGrades) != null)
				{
					GetSubjectGradesById(grade.IdSubjectGrades).AddGradeToGrades(grade);
				}
			}
			foreach (SubjectGrades subjectGrades in subjectGrades)
			{
				if (GetStudentFromLocal(subjectGrades.IdUser) != null)
				{
					GetStudentFromLocal(subjectGrades.IdUser).AddSubjectGradesToGradeBook(subjectGrades);
				}
			}
		}
        ///////////////////////////////////////////////////////////////
		public static User GetUserFromLocal(int userId)
        {
            foreach (User user in users)
            {
                if (user.Userid == userId)
                {
                    return user;
                }
            }
            return null;
        }

        public static List<Teacher> GetTeachersFromLocal()
        {
            List<Teacher> teachers = new List<Teacher>();
            foreach (User user in users)
            {
                if (user.GetType()==typeof(Teacher))
                {
                    teachers.Add((Teacher)user);
                }
            }
            return teachers;
        }
        public static Teacher? GetTeacherFromLocal(int? Userid)
        {
            if (Userid == null )
            {
                return null;
            }
            foreach (Teacher teacher in GetTeachersFromLocal())
            {
                if (teacher.Userid == Userid)
                {
                    return teacher;
                }
            }
            return null;

        }
        public static List<Teacher>? GetTeachersFromLocalByPartOfName(string partOfName)
        {
            List<Teacher> teachers = new List<Teacher>();
            foreach (Teacher teacher in GetTeachersFromLocal())
            {
                if (teacher.GetFullName().ToLower().Contains(partOfName.ToLower()))
                {
                    teachers.Add(teacher);
                }
            }
            return teachers;
        }

        public static List<Student> GetStudentsFromLocal()
        {
            List<Student> students = new List<Student>();
            foreach (User user in users)
            {
                if (user.GetType() == typeof(Student))
                {
                    students.Add((Student)user);
                }
            }
            return students;
        } // because there are students amongst teachers in users
		public static Student? GetStudentFromLocal(int Userid)
		{
			foreach (Student student in GetStudentsFromLocal())
			{
				if (student.Userid == Userid)
				{
					return student;
				}
			}
			return null;
		}
		public static List<Student>? GetStudentsFromLocalByPartOfName(string partOfName)
        {
            List<Student> students = new List<Student>();
            foreach (Student student in GetStudentsFromLocal())
            {
                if (student.GetFullName().ToLower().Contains(partOfName.ToLower()))
                {
                    students.Add(student);
                }
            }
            return students;
        }
        
        public static List<Class> GetClassesFromLocal()
        {
            return classes;
        }
        public static Class? GetClassFromLocal(int ClassName)
        {

            foreach (Class _class in classes)
            {
                if (_class.Name == ClassName)
                {
                    return _class;
                }
            }
            return null;
        }

        public static List<Grade> GetGrades()
        {
            return grades;
        }
        public static SubjectGrades? GetSubjectGradesById(int subjectGradesId)
        {
            foreach (SubjectGrades subjectGrades in subjectGrades)
            {
                if (subjectGrades.Id == subjectGradesId)
                {
                    return subjectGrades;
                }
            }
            return null;
        }
        public static void AddGrade(Grade grade)
        {
            grades.Add(grade);
        }

        public static int GetNextAvailableId()
        {
            int highestId = 0;
            foreach (Grade grade in grades)
            {
                if (grade.IdGrade>highestId)
                {
                    highestId = grade.IdGrade;
                }
            }
            return highestId + 1;
        }
    }
}
