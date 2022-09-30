using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonforms3;

class Student
{
    private static int _staticId = 0;
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public Student(string? name, string? surname)
    {
        Id = ++_staticId;
        Name = name;
        Surname = surname;
    }

    public override string ToString() => $"{Id}-{Name}-{Surname}";
}


