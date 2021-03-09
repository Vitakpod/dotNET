using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZooDatabase.DomainModel
{
    class KeepersList: IList<ZooKeeper>
    {
        private List<ZooKeeper> list { get; }
        private int amount = 0;

        public KeepersList()
        {
            list = new List<ZooKeeper>();
            amount = 0;
        }

        public void Add(ZooKeeper keeper)
        {
            keeper.Id = amount;
            amount++;
            list.Add(keeper);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(ZooKeeper item)
        {
            return list.Contains(item);
        }

        public void CopyTo(ZooKeeper[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public bool Remove(ZooKeeper item)
        {
            return list.Remove(item);
        }

        public int Count => list.Count;

        public bool IsReadOnly => ((ICollection<ZooKeeper>) list).IsReadOnly;

        public IEnumerator<ZooKeeper> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) list).GetEnumerator();
        }

        public int IndexOf(ZooKeeper item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, ZooKeeper item)
        {
            list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public ZooKeeper this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
}
