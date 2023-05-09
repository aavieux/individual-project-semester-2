using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class TeachersModel : PageModel
    {
        internal List<Teacher> teachers { get; set; }
        internal List<Teacher> foundTeachers { get; set; }
        internal List<Teacher> pastebinList { get; set; }
        internal bool foundUsers { get; set; }

        internal StatisticsManager statisticsManager;

        internal UserDatabaseHelper userDbHelper;
        internal ClassDatabaseHelper classDbHelper;
        internal GradeDatabaseHelper gradeDbHelper;

        internal ClassMapper classMapper;
        internal UserMapper userMapper;
        internal GradeMapper gradeMapper;


        public TeachersModel()
        {
            this.classDbHelper = new ClassDatabaseHelper();
            this.userDbHelper = new UserDatabaseHelper();
            this.gradeDbHelper = new GradeDatabaseHelper();

            this.classMapper = new ClassMapper(classDbHelper, userDbHelper, gradeDbHelper);
            this.userMapper = new UserMapper(userDbHelper, gradeDbHelper);
            this.gradeMapper = new GradeMapper(gradeDbHelper);

            statisticsManager = new StatisticsManager(classDbHelper, classMapper, userDbHelper, userMapper, gradeDbHelper, gradeMapper);
        }
        public void OnGet()
        {
            teachers = statisticsManager.GetAllTeachers();
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            foundUsers = false;

            teachers = statisticsManager.GetAllTeachers();
            string search = Request.Form["search"];
            foundTeachers = new List<Teacher>();
            foundTeachers = statisticsManager.GetTeachersByPartOfName(search);
            if (foundTeachers.Count != 0)
            {
                foundUsers = true;
            }
            return Page();
        }
    }
}
