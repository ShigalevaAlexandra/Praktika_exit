using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_exit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //описание работы программы
            Console.Write("Данная программа выполняется пока не введете слово EXIT \r\n\r\n");

            //объявление переменной для хранения вводимого значения
            string input_str;

            //объявление масисива диалога программы с пользователем
            string[] words_list = {
                "Привет)", "Как дела?", "ERROR: связь прервана",
                "поиск сети...", "подключение...", "обновление..." };

            int index_word = 0; //индекс слова из диалога 

            //цикл для перебора массива word_list до тех пор,
            //пока пользователь не ввдет слово EXIT
            do
            {
                Console.WriteLine(words_list[index_word]);
                index_word++;
                input_str = Console.ReadLine();

                //обработка ошибки выхода за границы массива
                if (index_word >= words_list.Length) index_word = 0;
                else continue;
            }
            while (input_str != "exit");

            Console.Write("\r\n завершение работы... \r\n\r\n");
        }
    }
}