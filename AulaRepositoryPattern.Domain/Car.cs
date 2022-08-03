using System;
using System.ComponentModel.DataAnnotations;
using AulaRepositoryPattern.Core.Models;

namespace AulaRepositoryPattern.Domain
{
    public class Car : Entity
    {
        [StringLength(100)]
        public string Name { get; private set; }
        
        public int HorsePower { get; private set; }
        
        public Car(Guid id, string name, int horsePower) : base(id)
        {
            Name = name;
            HorsePower = horsePower;
        }
    }
}