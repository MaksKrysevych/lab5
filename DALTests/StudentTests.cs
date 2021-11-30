using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL.Tests
{
    [TestClass()]
    public class StudentTests
    {
        EntityService es = new EntityService();

        [TestMethod()]
        public void StudentTest()
        {
            Student student1 = new Student(1, "q", "q", "12.07.1212", true, true, 809, 3, 1);
            Student student2 = new Student(2, "w", "w", "12.08.1212", true, true, 809, 3, 2);
            List<Student> students = new List<Student> { student1, student2 };
            int value = es.Student3rdCourseBirthInSummer(students);
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        public void Test2()
        {
            List<Student> students = new List<Student> { new Student(1, "q", "q", "12.07.1212", true, true, 809, 1, 1) };
            List<Teacher> teachers = new List<Teacher> { new Teacher("w", "w", 2, true, "12.08.1212") };
            List<Astronaut> astronauts = new List<Astronaut> { new Astronaut("e", "e", 3, false, "12.06.1212") };

            int value = es.PeopleWhoPlaySing(students, teachers, astronauts);
            Assert.AreEqual(2, value);
        }

        [TestMethod]
        public void Test3()
        {
            Student student1 = new Student(1, "q", "q", "12.07.1212", true, true, 809, 3, 1);
            Student student2 = new Student(2, "w", "w", "12.08.1212", true, true, 809, 3, 2);
            List<Student> students = new List<Student> { student1, student2 };
            int value = es.Student3rdCourseBirthInSummer(students);
            Assert.AreEqual(2, 2);
        }
    }
}