using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldSkills.ViewModel;
using WorldSkills.Model;

namespace UsersViewModelTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string login = "2";
            string password = "2";
            //Act
            UsersViewModel obj = new UsersViewModel();
            bool actual = obj.Auth(login,password);
            //Assert
            Assert.IsTrue(actual);

        }
    }
}
