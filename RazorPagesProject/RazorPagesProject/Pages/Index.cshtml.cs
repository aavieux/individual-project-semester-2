﻿using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Text.Json;
using System.Text;
using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using DataBaseClassLibrary.DatabaseHelpers;

namespace RazorPagesProject.Pages
{
    public class IndexModel : PageModel
    {
        internal StatisticsManager statisticsManager;

        internal UserDatabaseHelper userDbHelper;
        internal ClassDatabaseHelper classDbHelper;
        internal GradeDatabaseHelper gradeDbHelper;
        internal FeedbackDatabaseHelper feedbackDbHelper;

        internal ClassMapper classMapper;
        internal UserMapper userMapper;
        internal GradeMapper gradeMapper;
        internal FeedbackMapper feedbackMapper;


        public IndexModel()
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

        }
        public void OnGet()
        {
            
        }
        internal List<Student> GetBestStudents(int number)
        {
            return statisticsManager.GetBestStudents(number);

		}
    }
}