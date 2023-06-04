using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using Test.FakeDatabaseHelpers;

namespace Test
{
    public class Tests
    {
        private FakeUserDatabaseHelper userDbHelper = new FakeUserDatabaseHelper();
        private FakeGradeDatabaseHelper gradeDbHelper = new FakeGradeDatabaseHelper();

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void PromoteRole_RoleGetsPromoted_ReturnsTrue()
        {
            //arrange
            Teacher teacherTest = new Teacher(userDbHelper, gradeDbHelper, "Antonia", "Todorova", 
                ClassLibrary.Models.Enums.Role.COORDINATOR, 1, "antonia.todorova@gmail.com", "+359895693314");
            //act
            bool result = false;
            if (teacherTest.PromoteRole())
            {
                result = true;
            }
            

            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void PromoteRole_RoleDoesNotGetsPromoted_ReturnsFalse()
        {
            //arrange
            Teacher teacherTest = new Teacher(userDbHelper, gradeDbHelper, "Antonia", "Todorova",
                ClassLibrary.Models.Enums.Role.DIRECTOR, 1, "antonia.todorova@gmail.com", "+359895693314");
            //act
            bool result = false;
            if (teacherTest.PromoteRole())
            {
                result = true;
            }
            //assert
            Assert.IsFalse(result);
        }
        [Test]
        public void AddToClass_ValidClassId_ReturnsTrue()
        {
            // Arrange
            User user = new User(userDbHelper, gradeDbHelper, "Antonia", "Todorova",
                ClassLibrary.Models.Enums.Role.COORDINATOR, 0, "antonia.todorova@gmail.com", "+359895693314", 1);

            // Act
            bool result = user.AddToClass(0);

            // Assert
            Assert.IsTrue(result);
           
        }

        [Test]
        public void AddToClass_ClassAlreadyAssigned_ReturnsFalse()
        {
            // Arrange

            User user = new User(userDbHelper, gradeDbHelper, "Antonia", "Todorova",
                ClassLibrary.Models.Enums.Role.COORDINATOR, 1, "antonia.todorova@gmail.com", "+359895693314", 1);

            // Act
            bool result = user.AddToClass(1);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Update_ValidUser_ReturnsTrue()
        {
            // Arrange
            User user = new User(userDbHelper, gradeDbHelper, "Antonia", "Todorova",
                ClassLibrary.Models.Enums.Role.COORDINATOR, 1, "antonia.todorova@gmail.com", "+359895693314", 1);

            // Act
            user.SetId(100);
            bool result = user.Update();

            // Assert
            Assert.IsTrue(result);
        }
        //[Test]
        //public void Update_InValidUser_ReturnsFalse()
        //{
        //    // Arrange
        //    User user = new User(userDbHelper, gradeDbHelper, "Antonia", "Todorova",
        //        ClassLibrary.Models.Enums.Role.COORDINATOR, 1, "antonia.todorova@gmail.com", "359895693314", 1);

        //    // Act
        //    user.SetId(100);
        //    bool result = user.Update();

        //    // Assert
        //    Assert.IsTrue(result);
        //}

        [Test]
        public void ChangeClass_ValidClassId_CallsUpdate()
        {
            // Arrange
            int newClassId = 6;
            User user = new User(userDbHelper, gradeDbHelper, "Antonia", "Todorova",
                ClassLibrary.Models.Enums.Role.COORDINATOR, 1, "antonia.todorova@gmail.com", "+359895693314", 1);

            // Act
            bool result = user.ChangeClass(newClassId); // add return type

            // Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void ChangeClass_InValidClassId_CallsUpdate() // the class is the same 
        {
            // Arrange
            int newClassId = 1;
            User user = new User(userDbHelper, gradeDbHelper, "Antonia", "Todorova",
                ClassLibrary.Models.Enums.Role.COORDINATOR, 1, "antonia.todorova@gmail.com", "+359895693314", 1);

            // Act
            bool result = user.ChangeClass(newClassId); // add return type

            // Assert
            Assert.IsFalse(result);
        }
    }
}