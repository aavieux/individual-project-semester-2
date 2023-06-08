using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataBaseClassLibrary.Interfaces;


namespace RazorPagesProject.Pages
{
    public class _SubjectGradesViewModel : PageModel
    {
        
        [BindProperty]
        public int userId { get; set; }
        internal Student currentStudent { get; set; }

        internal StatisticsManager statisticsManager;

        internal UserDatabaseHelper userDbHelper;
        internal ClassDatabaseHelper classDbHelper;
        internal GradeDatabaseHelper gradeDbHelper;

        internal ClassMapper classMapper;
        internal UserMapper userMapper;
        internal GradeMapper gradeMapper;
        internal IConfiguration configuration;

        public _SubjectGradesViewModel(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.classDbHelper = new ClassDatabaseHelper(configuration);
            this.userDbHelper = new UserDatabaseHelper(configuration);
            this.gradeDbHelper = new GradeDatabaseHelper(configuration);

            this.classMapper = new ClassMapper(classDbHelper, userDbHelper, gradeDbHelper);
            this.userMapper = new UserMapper(userDbHelper, gradeDbHelper);
            this.gradeMapper = new GradeMapper(gradeDbHelper);

            statisticsManager = new StatisticsManager(classDbHelper, classMapper, userDbHelper, userMapper, gradeDbHelper, gradeMapper);
        }
        public void OnGet()
        {
            currentStudent = statisticsManager.GetStudentById(userId);
        }
    }
}
