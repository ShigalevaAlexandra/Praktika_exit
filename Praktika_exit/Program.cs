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
            Console.SetCursorPosition(0, 1);
            Console.Write("   * Данная программа выполняется пока не введете слово EXIT * \r\n\r\n");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(new string('_', Console.WindowWidth));

            //объявление переменной для хранения вводимого значения
            string input_str;

            //объявление масисива диалога программы с пользователем
            string[] words_list = {
                "Привет)", "Как дела?", "ERROR: связь прервана",
                "поиск сети...", "подключение...", "обновление..." };

            int index_word = 0,   //индекс слова из диалога 
                position_y = 4;   //позиция y

            //цикл для перебора массива word_list до тех пор,
            //пока пользователь не ввдет слово EXIT
            do
            {
                Console.SetCursorPosition(3, position_y);
                Console.WriteLine(words_list[index_word]);
                position_y += 2;
                index_word++;

                Console.SetCursorPosition(3, position_y);
                input_str = Console.ReadLine();
                position_y++;

                //обработка ошибки выхода за границы массива
                if (index_word >= words_list.Length) index_word = 0;
                else continue;
            }
            while (input_str != "exit");

            Console.Write("\r\n   --> завершение работы... \r\n\r\n");
        }
    }
}