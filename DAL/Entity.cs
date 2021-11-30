using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Student : IAbilityToSing, ICourse
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public bool AbilityToSing { get; set; }
        public bool InternetAccess { get; set; }

        public Student(int id, string lastname, string name, string birthday, bool abilityToSing, bool internetAccess, int age, int course, int group)
        {
            ID = id;
            LastName = lastname;
            Name = name;
            Birthday = birthday;
            AbilityToSing = abilityToSing;
            InternetAccess = internetAccess;
            Age = age;
            Course = course;
            Group = group;
        }

        public Student()
        {
        }
    }
    public class Teacher : IAbilityToSing
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public bool AbilityToSing { get; set; }

        public Teacher(string name, string lastname, int id, bool abilityToSing, string birthday)
        {
            ID = id;
            Name = name;
            LastName = lastname;
            AbilityToSing = abilityToSing;
            Birthday = birthday;
        }
        public Teacher()
        {

        }
    }
    public class Astronaut : IAbilityToSing
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public bool AbilityToSing { get; set; }

        public Astronaut(string name, string lastname, int id, bool abilityToSing, string birthday)
        {
            ID = id;
            Name = name;
            LastName = lastname;
            AbilityToSing = abilityToSing;
            Birthday = birthday;
        }
        public Astronaut()
        {

        }
    }

    interface ICourse
    {
        int Course { get; set; }
    }
    interface IAbilityToSing
    {
        bool AbilityToSing { get; set; }
    }
}
