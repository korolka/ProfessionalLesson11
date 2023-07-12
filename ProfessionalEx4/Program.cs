//Завдання 4

//Використовуючи конструкції блокування, модифікуйте останній приклад уроку таким чином, щоб отримати можливість послідовної роботи 3-х потоків.
using System.Diagnostics.Metrics;

namespace ProfessionalEx4
{
    class Program
    {
        static int counter = 0;

        static object block = new object(); // block - не повинен бути структурним.

        static void Function()
        {
            for (int i = 0; i < 50; ++i)
            {
                lock (block)
                {
                    Console.WriteLine(++counter);
                }
                // Виконання деякої роботи потоком ...


            }
        }

        static void Main()
        {
            Thread[] threads = { new Thread(Function), new Thread(Function), new Thread(Function) };

            foreach (Thread thread in threads)
                thread.Start();

            // Delay
            Console.ReadKey();
        }
    }
}