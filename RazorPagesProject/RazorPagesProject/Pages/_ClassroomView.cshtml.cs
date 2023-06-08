using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataBaseClassLibrary.Interfaces;

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

        internal ClassMapper classMapper;
        internal UserMapper userMapper;
        internal GradeMapper gradeMapper;
        internal IConfiguration configuration;
        public _ClassroomViewModel(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.classDbHelper = new ClassDatabaseHelper(configuration);
            this.userDbHelper = new UserDatabaseHelper(configuration);
            this.gradeDbHelper = new GradeDatabaseHelper(configuration);


            this.classMapper = new ClassMapper(classDbHelper,userDbHelper,gradeDbHelper);
            this.userMapper = new UserMapper(userDbHelper,gradeDbHelper);
            this.gradeMapper = new GradeMapper(gradeDbHelper);


            statisticsManager = new StatisticsManager(classDbHelper,classMapper,userDbHelper,userMapper,gradeDbHelper,gradeMapper);
            students = new List<Student>();
        }

        public void OnGet()
        {
            className = int.Parse(Request.Query["className"]);
            students = statisticsManager.GetClassById(className).GetStudents();// add exception check
        }
    }
}
