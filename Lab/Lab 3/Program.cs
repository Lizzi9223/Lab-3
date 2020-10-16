using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //использование конструктора без параметров
            Numbers first = new Numbers();
            first.add_el(12);
            first.add_el(23);
            first.show();
            first.del_el(1);
            first.show();
            first.size();
            //использование конструктора с параметрами
            int[] arr = new int[] {1,2,3,4,5};
            Numbers second = new Numbers(arr);
            second.show();
            //использование конструктора по умолчанию
            Numbers third = new Numbers(3);
            third.show();
            Numbers.quantity();
            if (first.Equals(third)) Console.WriteLine("yes");
            else Console.WriteLine("no");
            Console.WriteLine(second.GetHashCode());
            Console.WriteLine(first.ToString());
        }
    }    
}
