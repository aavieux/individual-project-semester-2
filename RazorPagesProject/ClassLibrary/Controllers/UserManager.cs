using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
	public class UserManager
	{
        UserDatabaseHelper userDbHelper;
        UserMapper userMapper;
        //GradeDatabaseHelper gradeDbHelper;
        public UserManager(UserDatabaseHelper userDbHelper, UserMapper userMapper) 
        {
            this.userDbHelper = userDbHelper;
            this.userMapper = userMapper;
            // this.gradeDbHelper = gradeDatabaseHelper;
        }
        
        public bool CreateUser(User user)
        {
            if (user.Userid == 0) // check if the user is loaded or now being created(when the id is 0 means that the user exist only in the business logic)
            {
                
                user.SetId(userDbHelper.AddUserToDB(userMapper.MapUserToUserDTO(user)));
                if (user.Userid != 0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(User user)
        {
            if (userDbHelper.DeleteUserFromDB(user.Userid))
            {
                return true;
            }
            return false;
        }
    }
}
