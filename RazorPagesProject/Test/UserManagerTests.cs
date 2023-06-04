using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FakeDatabaseHelpers;

namespace Test
{
    public class UserManagerTests
    {
        FakeUserDatabaseHelper userDbHelperMock = new FakeUserDatabaseHelper();
        FakeGradeDatabaseHelper gradeDbHelperMock = new FakeGradeDatabaseHelper();
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void CreateUser_WhenUserDoesNotExist_ShouldCreateUserAndReturnTrue() // create user
        {
            // Arrange

            UserMapper userMapperMock = new UserMapper(userDbHelperMock, gradeDbHelperMock);
            UserManager userManager = new UserManager(userDbHelperMock, userMapperMock);

            User user = new User(userDbHelperMock,gradeDbHelperMock,"Aleksandar", "Garkov", ClassLibrary.Models.Enums.Role.STUDENT, 1, "aleksandar.gvarkov@gmail.com","0895676656"); // User does not exist in the database

            // Act
            bool result = userManager.CreateUser(user);

            // Assert
            Assert.True(result);
            //Assert.Equals(1, user.Userid);
        }
        [Test]
        public void Delete_WhenUserExists_ShouldDeleteUserAndReturnTrue() // delete existing user
        {
            // Arrange
            UserMapper userMapperMock = new UserMapper(userDbHelperMock, gradeDbHelperMock);
            UserManager userManager = new UserManager(userDbHelperMock, userMapperMock);
            User user = new User(userDbHelperMock, gradeDbHelperMock, "Aleksandar", "Garkov", ClassLibrary.Models.Enums.Role.STUDENT, 8, "aleksandar.gvarkov@gmail.com", "0895676656",1); // User does not exist in the database

            // Act
            bool result = userManager.Delete(user);

            // Assert
            Assert.True(result);
        }
        [Test]
        public void Delete_WhenUserDoesNotExist_ShouldNotDeleteUserAndReturnFalse() // delete non- existing user
        {
            // Arrange
            UserMapper userMapperMock = new UserMapper(userDbHelperMock, gradeDbHelperMock);
            UserManager userManager = new UserManager(userDbHelperMock, userMapperMock);
            User user = new User(userDbHelperMock, gradeDbHelperMock, "Aleksandar", "Garkov", ClassLibrary.Models.Enums.Role.STUDENT, 1, "aleksandar.gvarkov@gmail.com", "0895676656",8); // User does not exist in the database

            // Act
            bool result = userManager.Delete(user);

            // Assert
            Assert.False(result);
        }
    }
}
