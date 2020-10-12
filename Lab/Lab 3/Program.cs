using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Numbers
    {
        public List<int> numb = new List<int>();
        const double PI = 3.14; //константа
        public readonly double ID = 18972.12265; //поле для чтения

        //конструктор БЕЗ ПАРАМЕТРОВА
        public Numbers() { numb.Add(1); }

        //конструктор С ПАРАМЕТРАМИ
        public Numbers(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
                numb.Add(n[i]);
        }

        //конструктор С ПАРАМЕТРАМИ ПО УМОЛЧАНИЮ
        public Numbers(int n = 2) { numb.Add(n); }
             
        //ДОБАВИТЬ ЭЛ-Т
        public void add_el(int n)
        {
            numb.Add(n);
        }
        //УДАЛИТЬ ЭЛ-Т
        public void del_el(int n)
        {
            numb.RemoveAt(n);
        }
        //ВЫВЕСТИ РАЗМЕР МНОЖЕСТВА
        public void size()
        {
            Console.WriteLine($"Размер множества равен {numb.Count};\n");
        }
        //ВЫВЕСТИ МНОЖЕСТВО НА КОНСОЛЬ
        public void show()
        {
            Console.Write("Элементы множества:\n");
            foreach (var item in numb)
                Console.Write(item+"\t");
            Console.WriteLine("\n");
        }

    }
    class Numbers_stat
    {
        static List<int> number = new List<int>();
        //конструктор СТАТИЧЕСКИЙ
        static Numbers_stat() { number.Add(3); }
    }
    class Numbers_priv
    {
        //конструктор ЗАКРЫТЫЙ
        private Numbers_priv()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //использование конструктора без параметров
            Numbers first = new Numbers();
            first.show();
            //использование конструктора с параметрами
            int[] arr = new int[] {1,2,3,4,5};
            Numbers second = new Numbers(arr);
            second.show();
            //использование конструктора по умолчанию
            Numbers third = new Numbers(3);
            third.show();
        }
    }    
}
