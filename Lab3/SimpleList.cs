using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LaboratoryWork3
{
    public class SimpleListItem<T>
    {
        // данные
        public T data { get; set; }
        // следующий элемент
        public SimpleListItem<T> next { get; set; }
        // конструктор
        public SimpleListItem(T param) => data = param;
    }

    public class SimpleList<T> : IEnumerable<T>
        where T : IComparable
    {
        protected SimpleListItem<T> first = null;
        protected SimpleListItem<T> last = null;

        public int Count
        {
            get { return _count; }
            protected set { _count = value; }
        }
        int _count;

        public void Add(T element)
        {
            var newItem = new SimpleListItem<T>(element);
            this.Count++;

            if (last == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                last.next = newItem;
                last = newItem;
            }
        }

        public SimpleListItem<T> GetItem(int number)
        {
            if ((number < 0) || (number >= Count))
            {
                throw new Exception("Выход за границу индекса");
            }
            SimpleListItem<T> current = first;
            int i = 0;

            while (i < number)
            {
                current = current.next;
                i++;
            }

            return current;
        }

        public T Get(int number)
        {
            return GetItem(number).data;
        }
        public IEnumerator<T> GetEnumerator()
        {
            SimpleListItem<T> current = first;
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Sort()
        {
            Sort(0, Count - 1);
        }

        private void Sort(int low, int high)
        {
            int i = low;
            int j = high;
            T x = Get((low + high) / 2);
            do
            {
                while (Get(i).CompareTo(x) < 0) ++i;
                while (Get(j).CompareTo(x) > 0) --j;
                if (i <= j)
                {
                    Swap(i, j);
                    i++; j--;
                }
            } while (i <= j);
            if (low < j) Sort(low, j);
            if (i > high) Sort(i, high);
        }

        private void Swap(int i, int j)
        {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);
            T temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }
    }
}
