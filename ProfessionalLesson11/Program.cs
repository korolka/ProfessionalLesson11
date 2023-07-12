//Завдання 2

//Створіть консольну програму, яка в різних потоках зможе отримати доступ до 2-х файлів.
//Вважайте з цих файлів вміст і спробуйте записати отриману інформацію в третій файл.
//Читання/запис мають здійснюватися одночасно у кожному з дочірніх потоків.
//Використовуйте блокування потоків для того, щоб досягти коректного запису в кінцевий файл.
using System.Text;

namespace ProfessionalLesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string rozetkaComponent = "ComputerComponentRozetka.txt";
            string comfyComponent = "ComputerComponentComfy.txt";

            FileOperation fileOperation = new FileOperation();

            Thread rozentkaUndoxingTxt = new Thread(fileOperation.FileReader);
            rozentkaUndoxingTxt.Start(rozetkaComponent); 
            rozentkaUndoxingTxt.Join();

            Thread comfyUnboxingTxt = new Thread(fileOperation.FileReader);
            comfyUnboxingTxt.Start(comfyComponent);
        }
    }
}