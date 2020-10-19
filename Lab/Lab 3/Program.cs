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
            Console.WriteLine("Множество first (исходная версия)");
            first.add_el(12);
            first.add_el(23);
            first.show();
            Console.WriteLine("Множество first (после удаления одного из элементов)");
            first.del_el(1);
            first.show();
            Console.WriteLine("Множество first (размер множества)");
            first.size();
            //использование конструктора с параметрами
            int[] arr = new int[] {1,-2,3,-4,5};
            Numbers second = new Numbers(arr);
            Console.WriteLine("Множество second (исходная версия)");
            second.show();
            //использование конструктора по умолчанию
            Numbers third = new Numbers(3);
            Console.WriteLine("Множество third (исходная версия)");
            third.show();
            Numbers.quantity();
            if (first.Equals(third)) Console.WriteLine("first equals third");
            else Console.WriteLine("first DOES NOT equal third");
            Console.WriteLine("Множество second (second.GetHashCode)");
            Console.WriteLine(second.GetHashCode());
            Console.WriteLine("Множество first (first.ToString)");
            Console.WriteLine(first.ToString());

            //создание массива объектов
            Numbers[] obj = new Numbers[] { first, second, third };
            int max = first.sum(), max_index = 0, min = first.sum(), min_index = 0;
            int[] minus_obj = new int[obj.Length];
            for (int i=0;i<obj.Length;i++)
            {
                if(obj[i].sum()>max)
                {
                    max = obj[i].sum();
                    max_index = i;
                }
                if (obj[i].sum() < min)
                {
                    min = obj[i].sum();
                    min_index = i;
                }
                if (obj[i].minus())
                    minus_obj[i] = i;
                else minus_obj[i] = -1;
            }
            Console.WriteLine($"\nИндекс класса с макс. суммой = {max_index} (сумма = {max})");
            Console.WriteLine($"Индекс класса с мин. суммой = {min_index} (сумма = {min})");
            Console.Write("Индекс множеств с отрицательными элементами : ");
            foreach (var item in minus_obj)
                if (item >= 0) Console.Write(item + " ");
            Console.WriteLine();

            //Анонимный объект
            var anon = new { list = (9, -10, 34, 176, -21), id = 6743819, quant = 5 };
            Console.WriteLine($"\nАнонимный тип : {anon.list}\t{anon.id}\t{anon.quant}\n");
        }
    }    
}
