using System;
using System.Collections.Generic;
using System.Text;
using ZooDatabase.DomainModel.Contracts;

namespace ZooDatabase.DomainModel
{
    class Animal : IAnimal
    {
        public enum AnimalType
        {
            Fish,
            Amphibian,
            Bird,
            Reptile,
            Mammal
        }

        public Animal(string name, string area, ZooKeeper keeper, AnimalType type)
        {
            this.Id = 0;
            this.Name = name;
            this.Area = area;
            this.Type = type;
            this.Keeper = keeper;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public AnimalType Type { get; set; }
        public ZooKeeper Keeper { get; set; }

    }
}
