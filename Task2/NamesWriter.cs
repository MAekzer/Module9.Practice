using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class NamesWriter // Класс-подписчик
    {
        public void OnNamesSorted(string[] array)
        {
            foreach (string name in array)
                Console.WriteLine(name);
        }
    }
}
