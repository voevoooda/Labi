using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratoryWork3
{
    public class SimpleStack<T> : SimpleList<T>
        where T : IComparable
    {
        public void Push(T element)
        {
            Add(element);
        }

        public T Pop()
        {
            T current = default(T);
            if (Count == 0) return current;
            if (Count == 1)
            {
                current = first.data;
                first = null;
                last = null;
            }
            else
            {
                SimpleListItem<T> newLast = GetItem(Count - 2);
                current = newLast.next.data;
                last = newLast;
                newLast.next = null;
            }
            Count--;
            return current;
        }
    }
}
