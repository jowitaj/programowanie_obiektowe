using System;
using System.Collections.Generic;
using System.Text;

namespace Consolab02._2
{
   public class Person:
    {
        private string name;
        private int age;


     public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

       public  bool Equals(Person other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
        }
    }

    public class Student:
    {
        private string group;
        private List<Task> tasks;
        public string group;

        public Student (string name, int age, string group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            this.tasks = tasks;
        }

        //dokończyć
    }

    public class Teacher:
    {
        public Teacher(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //dokończyć
    }

    public class Task:
    {
        private string name;
        private TaskStatus status;
        public string name;
        public TaskStatus status;

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public bool Equals(Task other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(this.name, other.name) && Object.Equals(this.status, other.status);
        }
        //dokończyć
    }

    public class Classroom:
    {
        private string name;
        private string persons;
    
    public Classroom (string name)
    {
        this.name = name;
    }
        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }

    }
