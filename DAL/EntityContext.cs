using System;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    public class EntityContext
    {
        public readonly string path;

        public EntityContext()
        {
            path = Directory.GetCurrentDirectory() + "\\text.txt";
        }

        public bool DeleteAllInfo()
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        public string ReadAllInfo()
        {
            string Info = null;

            try
            {
                FileInfo fileInfo = new FileInfo(path);
                if (!fileInfo.Exists)
                {
                    fileInfo.Create();
                }

                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Unicode))
                {
                    Info = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Info;
        }

        public bool AddStudents(List<Student> students)
        {
            try
            {
                FileInfo FileInfo = new FileInfo(path);
                if (!FileInfo.Exists)
                {
                    FileInfo.Create();
                }

                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Unicode))
                {
                    foreach (Student s in students)
                    {
                        sw.WriteLine("ID: " + s.ID);
                        sw.WriteLine("Lastname: " + s.LastName);
                        sw.WriteLine("Firstname: " + s.Name);
                        sw.WriteLine("Birthday: " + s.Birthday);
                        sw.WriteLine("Age: " + s.Age);
                        sw.WriteLine("Ability to sing: " + s.AbilityToSing);
                        sw.WriteLine("Internet access: " + s.InternetAccess);
                        sw.WriteLine("Course: " + s.Course);
                        sw.WriteLine("Group: " + s.Group);
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;

        }
        public bool AddTeacher(List<Teacher> teachers)
        {
            try
            {
                FileInfo FileInfo = new FileInfo(path);
                if (!FileInfo.Exists)
                {
                    FileInfo.Create();
                }

                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Unicode))
                {
                    foreach (Teacher t in teachers)
                    {
                        sw.WriteLine("ID: " + t.ID);
                        sw.WriteLine("Lastname: " + t.LastName);
                        sw.WriteLine("Firstname: " + t.Name);
                        sw.WriteLine("Ability to sing: " + t.AbilityToSing);
                        sw.WriteLine("Birthday: " + t.Birthday);
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }
        public bool AddAstronaut(List<Astronaut> astronauts)
        {
            try
            {
                FileInfo FileInfo = new FileInfo(path);
                if (!FileInfo.Exists)
                {
                    FileInfo.Create();
                }

                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Unicode))
                {
                    foreach (Astronaut a in astronauts)
                    {
                        sw.WriteLine("ID: " + a.ID);
                        sw.WriteLine("Lastname: " + a.LastName);
                        sw.WriteLine("Firstname: " + a.Name);
                        sw.WriteLine("Ability to sing: " + a.AbilityToSing);
                        sw.WriteLine("Birthday: " + a.Birthday);
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }
    }
}
