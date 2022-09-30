using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task;

internal class User
{
   
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public DateTime BirthDate { get; set; }

    public User(string? name, string? surname, string? email, string? phone, DateTime birthDate)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Phone = phone;
        BirthDate = birthDate;
    }
}
