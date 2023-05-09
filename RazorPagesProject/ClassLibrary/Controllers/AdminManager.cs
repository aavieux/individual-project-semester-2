using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.Interfaces;
using DataBaseClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class AdminManager
    {
        private IUserDbHelper userDbHelper;
        private UserMapper userMapper;
        public AdminManager(IUserDbHelper userDbHelper, UserMapper userMapper) 
        {
            this.userDbHelper = userDbHelper;
            this.userMapper = userMapper;
        }
        public List<Manager> GetAllManagers()
        {
            List<Manager> managers = new List<Manager>();
            foreach (ManagerDTO managerDTO in userDbHelper.GetAllManagersFromDB())
            {
                managers.Add((Manager)userMapper.MapManagerDTOtoManager(managerDTO));
            }
            return managers;
        } // to do mapping
    }
}
