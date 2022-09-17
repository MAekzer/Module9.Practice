using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class NamesSorter // Класс-издатель
    {
        public delegate void NamesSortedEventHandler(string[] array);

        public event NamesSortedEventHandler NamesSorted;

        public void SortNames(string[] array)
        {
            Console.WriteLine("Введите число 1 или 2: ");

            var v = Convert.ToInt32(Console.ReadLine());

            if (v == 1 | v == 2)
            {
                Array.Sort(array);
                if (v == 2)
                    Array.Reverse(array);
            }
            else throw new FormatException();

            OnNamesSorted(array);
        }

        protected virtual void OnNamesSorted(string[] array)
        {
            NamesSorted?.Invoke(array);
        }
    }
}
