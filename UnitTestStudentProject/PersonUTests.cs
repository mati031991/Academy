using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentProject;
using System;

namespace UnitTestStudentProject
{
    [TestClass]
    public class PersonUTests
    {
        [TestMethod]
        public void GetName()
        {
            //Arrange
            string forname = "fornamname1";
            string name = "name1";
            string birthdaydate = DateTime.Now.ToString("yyyy-MM-dd");

            //Act
            Person p1 = new Person(forname, name, birthdaydate);

            //Assert
            Assert.AreEqual(forname, p1.GetForname());
            Assert.AreEqual(name, p1.GetName());
            Assert.AreEqual(birthdaydate, p1.GetBirthdayDate());
        }


    }
}
