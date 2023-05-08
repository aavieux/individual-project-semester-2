using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class _ClassroomViewModel : PageModel
    {
        [BindProperty]
        public int className { get; set; }
        internal List<Student> students { get; set; }

        internal StatisticsManager statisticsManager;

        internal UserDatabaseHelper userDbHelper;
        internal ClassDatabaseHelper classDbHelper;
        internal GradeDatabaseHelper gradeDbHelper;
        internal FeedbackDatabaseHelper feedbackDbHelper;

        internal ClassMapper classMapper;
        internal UserMapper userMapper;
        internal GradeMapper gradeMapper;
        internal FeedbackMapper feedbackMapper;


        public _ClassroomViewModel()
        {
            this.classDbHelper = new ClassDatabaseHelper();
            this.userDbHelper = new UserDatabaseHelper();
            this.gradeDbHelper = new GradeDatabaseHelper();
            this.feedbackDbHelper = new FeedbackDatabaseHelper();

            this.classMapper = new ClassMapper(classDbHelper,userDbHelper,gradeDbHelper);
            this.userMapper = new UserMapper(userDbHelper,gradeDbHelper);
            this.gradeMapper = new GradeMapper(gradeDbHelper);
            this.feedbackMapper = new FeedbackMapper(feedbackDbHelper);

            statisticsManager = new StatisticsManager(classDbHelper,classMapper,userDbHelper,userMapper,gradeDbHelper,gradeMapper,feedbackDbHelper,feedbackMapper);
            students = new List<Student>();
        }

        public void OnGet()
        {
            className = int.Parse(Request.Query["className"]);
            students = statisticsManager.GetClassById(className).GetStudents();// add exception check
        }
    }
}
