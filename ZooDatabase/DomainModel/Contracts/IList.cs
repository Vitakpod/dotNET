using System;
using System.Collections.Generic;
using System.Text;

namespace ZooDatabase.DomainModel.Contracts
{
    interface IList<T>
    {
        public void Add(T t);
        public void Remove(T t);
        public T Find(int i);
    }
}
