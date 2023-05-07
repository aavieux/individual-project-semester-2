using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
	public class UserManager
	{
        DataBaseClassLibrary.DatabaseHelpers.UserDatabaseHelper dbHelper = new DataBaseClassLibrary.DatabaseHelpers.UserDatabaseHelper();
        Mapper.UserMapper mapper = new Mapper.UserMapper();
        public bool CreateUser(User user)
        {
            if (user.Userid == 0) // check if the user is loaded or now being created(when the id is 0 means that the user exist only in the business logic)
            {
                
                user.SetId(dbHelper.AddUserToDB(mapper.MapUserToUserDTO(user)));
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
            if (dbHelper.DeleteUserFromDB(user.Userid))
            {
                return true;
            }
            return false;
        }
    }
}
