using DataBaseClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.Interfaces
{
    public interface IUserDbHelper
    {
        public List<UserDTO> GetAllUsersFromDB();

        public int AddUserToDB(UserDTO userDTO);

        public bool UpdateUserToDB(UserDTO user);
        public bool DeleteUserFromDB(int userId);
        public List<ManagerDTO> GetAllManagersFromDB();
    }
}
