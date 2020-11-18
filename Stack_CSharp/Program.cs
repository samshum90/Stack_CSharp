using System;

namespace Stack_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();

            int ini = 1;
            int max = 5;

            for (int i = ini; i <= max; i++)
                stack.Push(i);
            
            for (int i = ini; i <= max; i++)
                Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }

}
