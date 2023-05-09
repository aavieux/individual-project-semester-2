using DataBaseClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.Interfaces
{
    public interface IClassDbHelper
    {
        public List<ClassDTO> GetClassesFromDB();

        public List<StudentDTO> GetClassStudentsFromDB(int classId);

        public bool CreateClass(ClassDTO classDTO);

    }
}
