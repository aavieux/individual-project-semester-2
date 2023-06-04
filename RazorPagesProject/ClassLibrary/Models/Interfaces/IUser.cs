using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.Interfaces
{
    public interface IUser
    {
        public bool PromoteRole();
        public bool AddToClass(int classId);
        public void ChangeClass(int newClassId);
       
        public string GetFullName();
        public void SetId(int id);
        public bool Update();
    }
}