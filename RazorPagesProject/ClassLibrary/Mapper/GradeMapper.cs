using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Mapper
{
    public class GradeMapper
    {
        private GradeDatabaseHelper gradeDbHelper;
        public GradeMapper(GradeDatabaseHelper gradeDbHelper) { this.gradeDbHelper = gradeDbHelper;}
        internal Grade MapGradeDTOtoGrade(GradeDTO gradeDTO)
        {
            Grade grade = new Grade(gradeDTO.IdGrade ,gradeDTO.IdSubjectGrades, Enum.Parse<Models.Enums.GradeEnum>(gradeDTO.GradeEnum.ToString()));
            return grade;
        }
        public GradeDTO MapGradeToGradeDTO(Grade grade)
        {
            GradeDTO gradeDTO = new GradeDTO(grade.IdSubjectGrades,Enum.Parse<DataBaseClassLibrary.DTOs.DTOEnums.GradeEnum>(grade.GradeEnum.ToString()));
            return gradeDTO;
        }
        public SubjectGrades MapSubjectGradesDTOtoSubjectGrades(SubjectGradesDTO subjectGradesDTO)
        {
            SubjectGrades subjectGrades = new SubjectGrades(gradeDbHelper,subjectGradesDTO.Id, Enum.Parse<Models.Enums.Subject>(subjectGradesDTO.Subject.ToString()), subjectGradesDTO.IdUser);
            return subjectGrades;
        }
        public SubjectGradesDTO MapSubjectGradestoSubjectGradesDTO(SubjectGrades subjectGrades)
        {
            SubjectGradesDTO subjectGradesDTO = new SubjectGradesDTO(subjectGrades.Id, Enum.Parse<DataBaseClassLibrary.DTOs.DTOEnums.Subject>(subjectGrades.Subject.ToString()), subjectGrades.IdUser);
            return subjectGradesDTO;
        }
    }
}
