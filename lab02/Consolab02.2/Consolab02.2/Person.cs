using System;
using System.Collections.Generic;
using System.Text;

namespace Consolab02._2
{
    class Person
    {
        private string name;
        private int age;
    }

    Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    bool Equals(Person other)
    {
        if (other == null) return false;
        if (other == this) return true;

        return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
    }
}
