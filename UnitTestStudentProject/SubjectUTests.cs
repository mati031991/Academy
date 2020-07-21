using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestStudentProject
{
    [TestClass]
    public class SubjectUTests
    {
        [TestMethod]
        public void GetSubject()
        {
            //Arrange

            Subject subject = new Subject(new Subject(name: "Biologia", direction: "Biologia", speciality: "Biologia", sesion: "drugi", amountHour: 50));
            //Act
            var name = subject.GetName();
            var direction = subject.GetDirection();
            var speciality = subject.GetSpeciality();
            //Assert
            Assert.AreEqual("Biologia", subject.GetName());
            Assert.AreEqual("Biologia", subject.GetDirection());
            Assert.AreEqual("Biologia", subject.GetSpeciality());
            Assert.AreEqual("drugi", subject.GetSesion());
            Assert.AreEqual(50, subject.GetAmountHour());
        }
    }
}
