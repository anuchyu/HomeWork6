using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание: справочник «Сотрудники».");
            using (StreamWriter guide = new StreamWriter("Guide.csv", true, Encoding.UTF8)) 
            {
                char key = 'д';

                int i = 1;

                string note = string.Empty;
                note += "ID\t" + "Дата\t" + "ФИО\t" + "Возраст\t" + "Рост\t" + "Дата рождения\t" + "Место рождения\t";
                do
                {
                    note = string.Empty;
                    Console.WriteLine($"ID пользователя {i}.");
                    note += $"{i}\t";
                    i++;

                    string now = DateTime.Now.ToShortTimeString();
                    Console.WriteLine($"Время заметки: {now}");
                    note += $"{now}\t";

                    Console.WriteLine("Введите ФИО пользователя");
                    note += $"{Console.ReadLine()}\t";

                    Console.WriteLine("Введите возраст пользователя");
                    note += $"{Convert.ToInt32(Console.ReadLine())}\t";

                    Console.WriteLine("Введите рост пользователя");
                    note += $"{Convert.ToInt32(Console.ReadLine())}\t";

                    Console.WriteLine("Введите дату рождения пользователя");
                    note += $"{Console.ReadLine()}\t";

                    Console.WriteLine("Введите место рождения пользователя");
                    note += $"{Console.ReadLine()}\t";
                    
                    guide.WriteLine(note);

                    Console.WriteLine("Продолжить? н/д");
                 
                    key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'д');
            }
            Console.ReadKey();

            using (StreamReader guade = new StreamReader("Guide.csv",Encoding.UTF8))
            {
                string line;
            while ((line = guade.ReadLine()) != null)
                {
                    string[] data = line.Split('\t');
                    Console.WriteLine($"{data[0]}#{ data[1]}#{ data[2]}#{ data[3]}#{ data[4]}#{ data[5]}");
                }
            }

        }
    }
}
