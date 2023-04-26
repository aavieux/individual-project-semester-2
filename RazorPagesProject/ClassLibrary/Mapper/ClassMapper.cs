using ClassLibrary.Models;
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
        public Class MapClassDTOtoClass(ClassDTO classDTO)
        {
            Class currentClass = new Class(classDTO.Name, classDTO.TeacherID);
            return currentClass;
        }
        public ClassDTO MapClassToClassDTO(Class currentClass)
        {
            ClassDTO currentClassDTO = new ClassDTO(currentClass.Name, currentClass.TeacherID);
            return currentClassDTO;
        }
    }
}