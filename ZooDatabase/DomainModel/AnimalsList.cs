using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZooDatabase.DomainModel
{
    class AnimalsList: IList<Animal>
    {
        private List<Animal> list { get;}
        private int amount;

        public AnimalsList()
        {
            list = new List<Animal>();
            amount = 0;
        }

        public void Add(Animal an)
        {
            an.Id = amount;
            amount++;
            list.Add(an);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Animal item)
        {
            return list.Contains(item);
        }

        public void CopyTo(Animal[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        bool ICollection<Animal>.Remove(Animal item)
        {
            return list.Remove(item);
        }

        public int Count => list.Count;

        public bool IsReadOnly => ((ICollection<Animal>) list).IsReadOnly;

        public void Remove(Animal an)
        {
            list.Remove(an);
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) list).GetEnumerator();
        }

        public int IndexOf(Animal item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, Animal item)
        {
            list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public Animal this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
        public Animal Find(int Id)
        {
            foreach (Animal an in list)
            {
                if (an.Id == Id)
                {
                    return an;
                }
            }

            return null;
        }
    }
}
