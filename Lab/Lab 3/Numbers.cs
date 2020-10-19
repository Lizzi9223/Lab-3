using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public partial class Numbers
    {
        private List<int> numb { get; set; } = new List<int>();
        private const double PI  = 3.14; //константа
        private readonly long ID; //поле для чтения
        static int quant = 0;

        //конструктор БЕЗ ПАРАМЕТРОВА
        public Numbers() 
        { 
            numb.Add(1);
            ID = numb.GetHashCode();
        }

        //конструктор С ПАРАМЕТРАМИ
        public Numbers(int[] n)
        {
            numb.AddRange(n);
            ID = numb.GetHashCode();
        }

        //конструктор С ПАРАМЕТРАМИ ПО УМОЛЧАНИЮ
        public Numbers(int n = 2) 
        { 
            numb.Add(n);
            ID = numb.GetHashCode();
        }

        //закрытый конструктор
        private Numbers(int n = 1, int m = 2)
        {
            numb.Add(n);
            numb.Add(m);
            ID = numb.GetHashCode();
        }

        //конструктор СТАТИЧЕСКИЙ
        static Numbers()
        {
            Console.WriteLine("Был вызван статический конструктор.");
            quant++;
        }
    }

    public partial class Numbers
    {
        //ДОБАВИТЬ ЭЛ-Т
        public void add_el(int n)
        {
            numb.Add(n);
        }
        //УДАЛИТЬ ЭЛ-Т ПО ИНДЕКСУ
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
                Console.Write(item + "\t");
            Console.WriteLine("\n");
        }
        //ВЫВЕСТИ КОЛ-ВО ЭКЗЕМПЛЯРОВ КЛАСС
        public static void quantity()
        {
            Console.WriteLine($"Количество экземпляров класса равно {quant};");
        }
        //СУММА ЭЛЕМЕНТОВ КЛАССА
        public int sum()
        {
            int sum = 0;
            foreach (var item in numb)
                sum += item;
            return sum;
        }
        //ПРОВЕРКА НА СОДЕРЖАНИЕ ОТРИЦАТЕЛЬНЫХ ЭЛЕМЕНТОВ
        public bool minus()
        {
            bool check = false;
            foreach (var item in numb)
            {
                if(item<0)
                {
                    check = true;
                    return check;
                }
            }
            return check;
        }
        //переопределение метода класса Object.Equals()
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Numbers check = obj as Numbers; //возвращает null если объект нельзя привести к типу Numbers
            if (check as Numbers == null) return false;
            //return base.Equals(obj);
            int i = 0;
            while (i<check.numb.Count&&i<this.numb.Count)
            {
                if (check.numb[i] != this.numb[i]) return false;
                i++;
            }
            return true;
        }
        //переопределение метода класса Object.GetHashCode()
        public override int GetHashCode()
        {
            int code = 0;
            foreach (var item in this.numb)
                code += item;
            code /= this.numb[0];
            return code;
        }
        //переопределение метода класса Object.ToString()
        public override string ToString()
        {
            string str = "Elements: ";
            for (int i = 0; i < this.numb.Count; i++)
                str += $"{this.numb[i]} ";
            str += $"\tHashCode = {this.GetHashCode()}\tQuantity = {this.numb.Count}\tID = {this.ID}";
            return str;
        }
    }
}
