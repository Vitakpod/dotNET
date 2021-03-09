using System;
using System.Collections.Generic;
using System.Text;

namespace ZooDatabase.DomainModel.Contracts
{
    interface IAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public Animal.AnimalType Type { get; set; }
    }
}
