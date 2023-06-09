using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataBaseClassLibrary.Interfaces;

namespace RazorPagesProject.Pages
{
    
    public class ClassesModel : PageModel
    {
        internal List<Class> classes { get; set; }

        internal StatisticsManager statisticsManager;

        internal UserDatabaseHelper userDbHelper;
        internal ClassDatabaseHelper classDbHelper;
        internal GradeDatabaseHelper gradeDbHelper;

        internal ClassMapper classMapper;
        internal UserMapper userMapper;
        internal GradeMapper gradeMapper;
        public ClassesModel()
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
            classes = statisticsManager.GetAllClasses();

        }
        public string GetTeacherNameById(int teacherId)
        {
            return statisticsManager.GetTeacherById(teacherId).GetFullName();
        }
        
    }
}
