using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class EntityService
    {
        public void AddStudent(List<Student> students)
        {
            Console.WriteLine("Count of persons: ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("Lastname");
                string lastname = Console.ReadLine();
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Birthday:");
                string birthday = Console.ReadLine();
                Console.WriteLine("Can this person sing?(y/n)");
                string AbilityToSing = Console.ReadLine();
                Console.WriteLine("Do this person have a connection to the Internet?(y/n)");
                string InternetSuccess = Console.ReadLine();
                Console.WriteLine("Course:");
                int course = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Group:");
                int group = Convert.ToInt32(Console.ReadLine());

                bool abilityToSing;
                bool internetSuccess;

                if (InternetSuccess == "y")
                {
                    internetSuccess = true;
                }
                else
                {
                    internetSuccess = false;
                }

                if (AbilityToSing == "y")
                {
                    abilityToSing = true;
                }
                else
                {
                    abilityToSing = false;
                }

                DateTime birth = DateTime.Parse(birthday);
                DateTime today = DateTime.Today;
                int age = today.Year - birth.Year;

                students.Add(new Student(id, lastname, name, birthday, abilityToSing, internetSuccess, age, course, group));
            }
        }
        public void AddTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("Count of persons: ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("Lastname");
                string lastname = Console.ReadLine();
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Can this person sing?(y/n)");
                string AbilityToSing = Console.ReadLine();
                Console.WriteLine("Birthday:");
                string birthday = Console.ReadLine();

                bool abilityToSing;

                if (AbilityToSing == "y")
                {
                    abilityToSing = true;
                }
                else
                {
                    abilityToSing = false;
                }

                teachers.Add(new Teacher(lastname, name, id, abilityToSing, birthday));
            }
        }
        public void AddAstronaut(List<Astronaut> astronauts)
        {
            Console.WriteLine("Count of persons: ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("Lastname");
                string lastname = Console.ReadLine();
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Can this person sing?(y/n)");
                string AbilityToSing = Console.ReadLine();
                Console.WriteLine("Birthday:");
                string birthday = Console.ReadLine();

                bool abilityToSing;
                if (AbilityToSing == "y")
                {
                    abilityToSing = true;
                }
                else
                {
                    abilityToSing = false;
                }

                astronauts.Add(new Astronaut(lastname, name, id, abilityToSing, birthday));
            }
        }

        public void DeleteStudent(List<Student> students)
        {
            Console.WriteLine("ID of student:");
            int key = int.Parse(Console.ReadLine());
            students.Remove(students.Find(r => r.ID == key));
        }
        public void DeleteTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("ID of teacher:");
            int key = int.Parse(Console.ReadLine());
            teachers.Remove(teachers.Find(r => r.ID == key));
        }
        public void DeleteAstronaut(List<Astronaut> astronauts)
        {
            Console.WriteLine("ID of astronaut:");
            int key = int.Parse(Console.ReadLine());
            astronauts.Remove(astronauts.Find(r => r.ID == key));
        }

        public void ShowAllInfo(List<Student> students, List<Teacher> teachers, List<Astronaut> astronauts)
        {
            foreach (Student s in students)
            {
                Console.WriteLine("ID: " + s.ID);
                Console.WriteLine("Lastname: " + s.LastName);
                Console.WriteLine("Firstname: " + s.Name);
                Console.WriteLine("Birthday: " + s.Birthday);
                Console.WriteLine("Ability to sing:" + s.AbilityToSing);
                Console.WriteLine("Age: " + s.Age);
                Console.WriteLine("Course: " + s.Course);
                Console.WriteLine("Group: " + s.Group);
                Console.WriteLine();
            }
            foreach (Teacher t in teachers)
            {
                Console.WriteLine("ID: " + t.ID);
                Console.WriteLine("Lastname: " + t.LastName);
                Console.WriteLine("Firstname: " + t.Name);
                Console.WriteLine("Ability to sing:" + t.AbilityToSing);
                Console.WriteLine("Birthday: " + t.Birthday);
                Console.WriteLine();
            }
            foreach (Astronaut a in astronauts)
            {
                Console.WriteLine("ID: " + a.ID);
                Console.WriteLine("Lastname: " + a.LastName);
                Console.WriteLine("Firstname: " + a.Name);
                Console.WriteLine("Ability to sing:" + a.AbilityToSing);
                Console.WriteLine("Birthday: " + a.Birthday);
                Console.WriteLine();
            }
        }

        public void UpdateStudent(List<Student> students)
        {
            Console.WriteLine("ID of student:");
            var key = int.Parse(Console.ReadLine());
            if (students.Contains(students.Find(r => r.ID == key)) && students[students.FindIndex(r => r.ID == key)].Course < 6)
            {
                Console.WriteLine("New course:");
                var NewCourse = int.Parse(Console.ReadLine());
                if (NewCourse > 6)
                {
                    Console.WriteLine("Max course is 6!");
                }
                else
                {
                    students[students.FindIndex(r => r.ID == key)].Course = NewCourse;
                }
            }
            if (students.Contains(students.Find(r => r.ID == key)) && students[students.FindIndex(r => r.ID == key)].Course == 6)
            {
                Console.WriteLine("Max course is 6!");
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }

        public int Student3rdCourseBirthInSummer(List<Student> students)
        {
            int counter = 0;
            foreach (var student in students)
            {
                if (student.Course == 3)
                {
                    DateTime time = DateTime.Parse(student.Birthday);
                    if (time.Month > 5 && time.Month < 9)
                    {
                        counter++;
                    }
                }
                
            }
            return counter;
        }

        public int PeopleWhoPlaySing(List<Student> students, List<Teacher> teachers, List<Astronaut> astronauts)
        {
            int counter1 = 0;
            foreach (var student in students)
            {
                if (student.AbilityToSing == true)
                {
                        counter1++;
                }

            }

            int counter2 = 0;
            foreach (var teacher in teachers)
            {
                if (teacher.AbilityToSing == true)
                {
                    counter2++;
                }

            }

            int counter3 = 0;
            foreach (var atronaut in astronauts)
            {
                if (atronaut.AbilityToSing == true)
                {
                    counter3++;
                }

            }

            int counter = counter1 + counter2 + counter3;

            return counter;
        }

        public int StudentsWhoHaveAccessToTheInternet(List<Student> students)
        {
            int counter = 0;
            foreach (var student in students)
            {
                if (student.InternetAccess == true)
                {
                    counter++;
                }

            }
            return counter;
        }
    }
}
