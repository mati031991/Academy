using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestStudentProject
{
    [TestClass]
    public class StudentUTests
    {
        [TestMethod]
        public void GetStudent()
        {
            //Arrange
            string forname = "formane1";
            string name = "name1";
            string bDate = DateTime.Now.ToString("yyyy-MM-dd");
            string direction = "direction1";
            string speciality = "speciality1";
            int year = 5;
            int group = 2;
            int index = 145698;

            //Act
            Student s1 = new Student(forname, name, bDate, direction, speciality, year, group, index);
            //Assert
            Assert.AreEqual(forname, s1.GetForname());
            Assert.AreEqual(name, s1.GetName());
            Assert.AreEqual(bDate, s1.GetBirthdayDate());
            Assert.AreEqual(direction, s1.GetDirection());
            Assert.AreEqual(speciality, s1.GetSpeciality());
            Assert.AreEqual(year, s1.GetYear());
            Assert.AreEqual(group, s1.GetGroup());
            Assert.AreEqual(index, s1.GetIndex());
        }
    }
}
