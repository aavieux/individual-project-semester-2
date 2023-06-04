using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FakeDatabaseHelpers
{
    public class FakeClassDatabaseHelper : IClassDbHelper
    {
        public List<ClassDTO> GetClassesFromDB()
        {
            List<ClassDTO> classes = new List<ClassDTO>();
            return classes;
        }
        
        public List<StudentDTO> GetClassStudentsFromDB(int classId)
        {
            List<StudentDTO> students = new List<StudentDTO>();
            return students;
        }
        

        public bool CreateClass(ClassDTO classDTO)
        {
            return true;
        }
        
    }
}
