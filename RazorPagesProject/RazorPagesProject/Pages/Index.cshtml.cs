﻿using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Text.Json;
using System.Text;
using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models.Interfaces;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace RazorPagesProject.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        internal StatisticsManager statisticsManager;

        internal UserDatabaseHelper userDbHelper;
        internal ClassDatabaseHelper classDbHelper;
        internal GradeDatabaseHelper gradeDbHelper;

        internal ClassMapper classMapper;
        internal UserMapper userMapper;
        internal GradeMapper gradeMapper;

        internal ICalculator calculator;

        public IndexModel(IConfiguration configuration)
        {

            this.classDbHelper = new ClassDatabaseHelper();
            this.userDbHelper = new UserDatabaseHelper();
            this.gradeDbHelper = new GradeDatabaseHelper();

            this.classMapper = new ClassMapper(classDbHelper, userDbHelper, gradeDbHelper);
            this.userMapper = new UserMapper(userDbHelper, gradeDbHelper);
            this.gradeMapper = new GradeMapper(gradeDbHelper);


            statisticsManager = new StatisticsManager(classDbHelper, classMapper, userDbHelper, userMapper, gradeDbHelper, gradeMapper);

            calculator = new CalculatorHigh(statisticsManager);
        }
        public void OnGet()
        {
            
        }
        internal List<Student> GetBestStudents(int number)
        {
            return calculator.GetBestStudents(number);

		}
    }
}