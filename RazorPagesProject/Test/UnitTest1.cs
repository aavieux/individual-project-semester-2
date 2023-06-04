using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using Test.FakeDatabaseHelpers;

namespace Test
{
    public class Tests
    {
        private FakeUserDatabaseHelper userDbHelper;
        private FakeGradeDatabaseHelper gradeDbHelper;

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void PromoteRoleTest()
        {
            //arrange
            userDbHelper = new FakeUserDatabaseHelper();
            gradeDbHelper = new FakeGradeDatabaseHelper();
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
    }
}