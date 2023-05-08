using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class StudentsModel : PageModel
    {
        [BindProperty]
        internal string search { get; set; }

        internal List<Student> students;
        internal List<Student> foundStudents { get; set; }
        internal List<Student> pastebinList { get; set; }
        internal bool foundUsers { get; set; }

        internal StatisticsManager statisticsManager;

        internal UserDatabaseHelper userDbHelper;
        internal ClassDatabaseHelper classDbHelper;
        internal GradeDatabaseHelper gradeDbHelper;
        internal FeedbackDatabaseHelper feedbackDbHelper;

        internal ClassMapper classMapper;
        internal UserMapper userMapper;
        internal GradeMapper gradeMapper;
        internal FeedbackMapper feedbackMapper;


        public StudentsModel()
        {
            this.classDbHelper = new ClassDatabaseHelper();
            this.userDbHelper = new UserDatabaseHelper();
            this.gradeDbHelper = new GradeDatabaseHelper();
            this.feedbackDbHelper = new FeedbackDatabaseHelper();

            this.classMapper = new ClassMapper(classDbHelper, userDbHelper, gradeDbHelper);
            this.userMapper = new UserMapper(userDbHelper, gradeDbHelper);
            this.gradeMapper = new GradeMapper(gradeDbHelper);
            this.feedbackMapper = new FeedbackMapper(feedbackDbHelper);

            statisticsManager = new StatisticsManager(classDbHelper, classMapper, userDbHelper, userMapper, gradeDbHelper, gradeMapper, feedbackDbHelper, feedbackMapper);
            students = new List<Student>();
        }
        public void OnGet()
        {
            students = statisticsManager.GetAllStudents();
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            foundUsers = false;

            students = statisticsManager.GetAllStudents();
            string search = Request.Form["search"];
            foundStudents = new List<Student>();
            foundStudents = statisticsManager.GetStudentsByPartOfName(search);
            if (foundStudents.Count != 0)
            {
                foundUsers = true;
            }
            return Page();
        }
        internal string? GetTeacherNameById(int Id)
        {
            if (Id == null)
            {
                return null;
            }
            else
            {
                string? teacherFullName = statisticsManager.GetTeacherById(Id).GetFullName();
                return teacherFullName;
            }
        }
    }
}
