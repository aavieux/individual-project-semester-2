using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.DTOs.DTOEnums;
using DataBaseClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FakeDatabaseHelpers
{
    public class FakeUserDatabaseHelper : IUserDbHelper
    {
        public List<UserDTO> users = new List<UserDTO>
        {
            new StudentDTO("John", "Doe", DataBaseClassLibrary.DTOs.DTOEnums.Role.STUDENT, 10, "john@example.com", "123456789", 1),
            new StudentDTO("Jane", "Smith", DataBaseClassLibrary.DTOs.DTOEnums.Role.STUDENT, 8, "jane@example.com", "987654321", 2),
            new TeacherDTO("Bob", "Johnson", DataBaseClassLibrary.DTOs.DTOEnums.Role.TEACHER1, 12, "bob@example.com", "456789123", 3),
            new TeacherDTO("Alice", "Williams", DataBaseClassLibrary.DTOs.DTOEnums.Role.TEACHER1, 9, "alice@example.com", "321654987", 4)
        };
        public List<ManagerDTO> managers = new List<ManagerDTO>
        {
            new ManagerDTO(1, "John", "Doe", "john@example.com", "password123"),
            new ManagerDTO(2, "Jane", "Smith", "jane@example.com", "password456"),
            new ManagerDTO(3, "Bob", "Johnson", "bob@example.com", "password789")
        };

        public FakeUserDatabaseHelper()
        {
            
        }
        public List<UserDTO> GetAllUsersFromDB()
        {
            return users;
        }

        public int AddUserToDB(UserDTO userDTO)
        {
            int newId = 5;
            users.Add(userDTO);
            Console.WriteLine("User added to the mock database with ID: " + newId);
            return newId;
        }

        public bool UpdateUserToDB(UserDTO user)
        {
            // Mock updating a user in the database
            Console.WriteLine("User updated in the mock database");
            return true;
        }

        public bool DeleteUserFromDB(int userId)
        {
            foreach (UserDTO userDTO in GetAllUsersFromDB())
            {
                if (userId == userDTO.Userid)
                {
                    users.Remove(userDTO);
                    Console.WriteLine("User deleted from the mock database");
                    return true;
                }
            }
            return false;
        }

        public List<ManagerDTO> GetAllManagersFromDB()
        {
            return managers;
        }
    }
}
