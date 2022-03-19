using System;
using System.Collections.Generic;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {
     
        }
    }

    class Person
    {
        protected string name;
        protected int age;
        public string Name
        {
            get { return Name; }
            set { Name = name; }
        }
        public int Age
        {
            get { return Age; }
            set { Age = age; }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return name;
        }

    }
    class Student : Person
    {
        protected string group;
        public string Group;
        List<Task> tasks = new List<Task>();


        public Student(string name, int age, string group) : base(name, age)
        {
            Group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age) { }


        class Task
        {
            private string name;
            private Task status;


            public string Name
            {
                get { return Name; }
                set { Name = name; }
            }
            public Task Status
            {
                get { return Status; }
                set { Status = status; }
            }

        }


        public void AddTask()
        {
            string taskName;
        }
        public void RemoveTask()
        {

        }
        public void UpdateTask()
        {

        }
        public void RenderTask()
        {

        }


        public override string ToString()
        {
            return group;
        }


    }

    class Teacher : Person
    {
        Teacher(string name, int age) : base(name, age) { }

        public override string ToString()
        {
            return name;
        }
    }

    public class Classroom
    {
        private string name;
        private Person[] persons;

        public string Name
        {
            get { return Name; }
            set { Name = name; }
        }

        public Classroom(string name)
        {
            this.name = name;
        }

        Classroom(string name, Person[] persons) : base(name) { }

        public override string ToString()
        {
            return name;
        }
    }


    
     

   

}
