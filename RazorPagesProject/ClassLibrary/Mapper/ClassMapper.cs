using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Mapper
{
    public class ClassMapper
    {
        ClassDatabaseHelper classDbHelper;
        UserDatabaseHelper userDbHelper;
        GradeDatabaseHelper gradeDbHelper;
        public ClassMapper(ClassDatabaseHelper classDbHelper, UserDatabaseHelper userDbHelper, GradeDatabaseHelper gradeDbHelper) 
        {
            this.userDbHelper = userDbHelper;
            this.classDbHelper = classDbHelper;
            this.gradeDbHelper = gradeDbHelper;
        }
        public Class MapClassDTOtoClass(ClassDTO classDTO)
        {
            Class currentClass = new Class(classDbHelper, userDbHelper,gradeDbHelper, classDTO.Name, classDTO.TeacherID);
            return currentClass;
        }
        public ClassDTO MapClassToClassDTO(Class currentClass)
        {
            ClassDTO currentClassDTO = new ClassDTO(currentClass.Name, currentClass.TeacherID);
            return currentClassDTO;
        }
    }
}