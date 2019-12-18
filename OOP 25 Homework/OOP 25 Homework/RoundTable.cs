using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_25_Homework
{
    class RoundTable<T> : IEnumerable<T> where T : IComparable<T>, IGetName
    {
        private List<T> entities = new List<T>();

        public T this[int index]
        {
            get
            {
                if (index >= 0)
                {
                    while (index >= entities.Count)
                    {
                        index = index - entities.Count;
                    }
                    return entities[index];
                }
                return default(T);
            }
        }

        public T this[string name]
        {
            get
            {
                foreach (T item in entities)
                {
                    if(item.GetName() == name)
                    {
                        return item;
                    }
                }
                return default(T);
            }
        }

        public void Add(T entity)
        {
            entities.Add(entity);
        }

        public void RemoveAt(int index)
        {
            if (index >= 0)
            {
                while (index >= entities.Count)
                {
                    index = index - entities.Count;
                }
                entities.RemoveAt(index);
            }
        }

        public void Clear()
        {
            entities.Clear();
        }

        public void InsertAt(int index, T entity) //5
        {
            if (index >= 0) //5 >= 0
            {
                while (index >= entities.Count) //5 >= 3 // 2 >= 3
                {
                    index = index - entities.Count; // 5 = 2
                }
                entities.Insert(index, entity); // 2
            }
        }

        public void Sort()
        {
            entities.Sort();
        }

        public List<T> GetRounded(int amount)
        {
            if (amount > 0)
            {
                List<T> roundedList = new List<T>();
                while (amount > entities.Count)
                {
                    roundedList.AddRange(entities);
                    amount = amount - entities.Count;
                }
                if (amount > 0)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        roundedList.Add(entities[i]);
                    }
                }
                return roundedList;
            }
            return null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        public override string ToString()
        {
            return $"RoundTable";
        }
    }
}
