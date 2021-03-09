using System;
using System.Collections.Generic;
using System.Text;
using ZooDatabase.DomainModel.Contracts;

namespace ZooDatabase.DomainModel
{
    class ZooKeeper : IKeeper
    {
        public ZooKeeper()
        {
            this.AnimalsList = new AnimalsList();
        }

        public ZooKeeper(string name, string lname)
        {
            this.Id = 0;
            this.FirstName = name;
            this.LastName = lname;
            this.AnimalsList = new AnimalsList();
        }
        public ZooKeeper(string name, string lname, AnimalsList list)
        {
            this.Id = 0;
            this.FirstName = name;
            this.LastName = lname;
            this.AnimalsList = list;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public AnimalsList AnimalsList { get; set; }

        public void Add(Animal an)
        {
            this.AnimalsList.Add(an);
        }

        public void Remove(int id)
        {
            Animal an = this.AnimalsList.Find(id);
            if (an != null)
            {
                this.AnimalsList.Remove(an);
            }
        }
    }
}
