using System;
using System.Collections.Generic;
using System.Text;

namespace ZooDatabase.DomainModel.Contracts
{
    interface IKeeper
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
