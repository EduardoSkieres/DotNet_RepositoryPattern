using System;
using AulaRepositoryPattern.Core.Models;

namespace AulaRepositoryPattern.Domain
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int Age { get; private set; }

        public User(Guid id, string name, string email, int age) : base(id)
        {
            Name = name;
            Email = email;
            Age = age;
        }
    }
}