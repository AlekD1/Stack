using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._05_Stack
{
    class StackFunction
    {
        public static Stack<int> CreateRanStack(int m)
        {
            Random ran = new Random();
            Stack<int> NewStack = new Stack<int>();
            for (int i = 0; i < m; i++)
                NewStack.Push(ran.Next(-5,5));
            return NewStack;
        }
        public static void WryteRanStack(Stack<int> RanStack)
        {
            foreach (int item in RanStack)
                Console.Write("{0} \t", item);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создание стека случайных чисел, сосотоящего из m элементов
            Console.WriteLine("Из скольких элементов будет создан новый стек?");
            int m = Convert.ToInt32(Console.ReadLine());
            Stack<int> stack = StackFunction.CreateRanStack(m);
            StackFunction.WryteRanStack(stack);
            // Подсчет нулевых жлементов
            int count = 0;
            foreach (int item in stack) if (item == 0) count++;
            if (count == 0) Console.WriteLine("Нулевые элементы отсутсвуют");
            else Console.WriteLine("Количество нулевых элементов = {0}", count);
            // Подсчет количетсва четных чисел
            count = 0;
            foreach (int item in stack) if (item % 2 == 0) count++;
            if (count == 0) Console.WriteLine("Четные числа отсутсвуют");
            else Console.WriteLine("Количество четных чисел = {0}", count);
            // Вывод вершины стека без удаления
            Console.WriteLine("Вершина стека = {0}", stack.Peek());
            // Извлечения последовательности из стека в динамичесский  массив
            ArrayList array = new ArrayList();
            while (stack.Count > 0) array.Add(stack.Pop());
            // Вывод массива
            Console.WriteLine("Массив сосотоящий из элементов стека");
            foreach (int item in array) Console.Write("{0} \t", item);
            Console.ReadLine();
        }
    }
}
