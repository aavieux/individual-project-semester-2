using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using ClassLibrary.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class CalculatorHigh : ICalculator
    {
        private StatisticsManager statisticsManager;
        public CalculatorHigh(StatisticsManager statisticsManager) 
        {
            this.statisticsManager = statisticsManager;
        }
        public string GetAvgGradeForSubject(Subject subject)
        {
            double result = 0.0;
            int numberOfGrades = 0;

            foreach (SubjectGrades subjectGrade in (statisticsManager.GetAllSubjectGrades()))
            {
                if (subjectGrade.Subject == subject)
                {
                    foreach (Grade grade in subjectGrade.GetGrades())
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
            }
            double avgGrade = result / numberOfGrades;
            if (avgGrade <= 1.9)
            {
                if (avgGrade >= 1.5)
                {
                    return "UNDEFINED / SUFFICIENT";
                }
                else return "UNDEFINED";

            }
            else if (avgGrade >= 2.0 && avgGrade <= 2.9)
            {
                if (avgGrade >= 2.5)
                {
                    return "SUFFICIENT / GOOD";
                }
                else return "SUFFICIENT";

            }
            else if (avgGrade >= 3.0 && avgGrade <= 3.9)
            {
                if (avgGrade >= 3.5)
                {
                    return "GOOD / ADVANCED";
                }
                else return "GOOD";

            }
            else if (avgGrade == 4.0)
            {
                return "ADVANCED";
            }
            else return "Error!";
        }
        public List<Student> GetBestStudents(int number)
        {
            List<Student> currentStudents = statisticsManager.GetAllStudents();
            currentStudents.Sort((s1, s2) => s1.GetAvgGrades().CompareTo(s2.GetAvgGrades()));

            List<Student> result = new List<Student>();
            int studentsNumber = statisticsManager.GetAllStudents().Count;
            if (number > studentsNumber)
            {
                number = studentsNumber;
            }
            for (int i = 0; i < number; i++)
            {
                result.Add(currentStudents[i]);
                result.Reverse();
            }
            return result;
        }
    }
}
