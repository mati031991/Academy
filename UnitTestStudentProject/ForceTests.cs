using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentProject;

namespace UnitTestStudentProject
{
    [TestClass]
    public class ForceTests
    {
        protected Force Force = new Force("Inżynieria biomedyczna", "44-100 Gliwice ul. Akademicka 1");
        protected Lecturer Lecturer1 = new Lecturer("Jan", "Testowy", "1985-12-24", "Dr", "Wykładowca");
        protected Lecturer Lecturer2 = new Lecturer("Anna", "Jaracz", "1971-12-31", "Dr hab", "Wykładowca");
        protected Lecturer Lecturer3 = new Lecturer("Damian", "Słonina", "1956-10-01", "Dr hab", "Dziekan");

        [TestMethod]
        public void GetForces()
        {
            //Act
            Force.AddLecturer(Lecturer1);
            Force.AddLecturer(Lecturer2);
            Force.AddLecturer(Lecturer3);
            //Assert
            StringAssert.Contains(Force.GetForceAddress(), "44-100 Gliwice ul. Akademicka 1");
            StringAssert.Contains(Force.GetForceName(), "Inżynieria biomedyczna");
        }

        [TestMethod]
        public void DeleteForcesLecturer()
        {
            //Act
            Force.AddLecturer(Lecturer1);
            Force.AddLecturer(Lecturer2);
            Force.AddLecturer(Lecturer3);
            var result1 = Force.DeleteLecturer("Jan", "Testowy");
            var result2 = Force.DeleteLecturer("Antoni", "Testowy");
            var result3 = Force.DeleteLecturer(Lecturer2);
            //Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }
    }
}
