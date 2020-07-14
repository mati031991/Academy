using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentProject;

namespace UnitTestStudentProject
{
    [TestClass]
    public class ForceTests
    {
        protected Force Force = new Force("Inżynieria biomedyczna", "44-100 Gliwice ul. Akademicka 1");
        protected Lecturer Lecturer1 = new Lecturer("Dr", "Wykładowca");
        protected Lecturer Lecturer2 = new Lecturer("Dr hab", "Wykładowca");

        [TestMethod]
        public void GetForces()
        {
            //Act
            Force.AddLecturer(Lecturer1);
            Force.AddLecturer(Lecturer2);
            //Assert
            StringAssert.Contains(Force.GetForceAddress(), "44-100 Gliwice ul. Akademicka 1");
            StringAssert.Contains(Force.GetForceName(), "Inżynieria biomedyczna");
        }
    }
}
