using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancedc_
{
    class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
    }

    class Squad<T> : IEnumerable<T>
    {
        private List<T> elements = new List<T>();

        public void Add(T item)
        {
            elements.Add(item);
        }

        public List<Hero> FindStrongHeroes()
        {
            List<Hero> result = new List<Hero>();

            foreach (var item in elements)
            {
                if (item is Hero h && h.Level >= 50)
                {
                    result.Add(h);
                }
            }

            return result;
        }

        public T Find(Func<T, bool> condition)
        {
            foreach (var item in elements)
            {
                if (condition(item))
                {
                    return item;
                }
            }
            return default;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }