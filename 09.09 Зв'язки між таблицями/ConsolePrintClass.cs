using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModels
{
    public static class ConsolePrintClass
    {
        public static void PrintResults<T>(IEnumerable<T> results, string header, Action<T> printAction)
        {
            Console.WriteLine(header); // Печатаем заголовок
            // принудительно матерализуем запрос что бы не обращаться к бд дважды
            var resultList = results.ToList();
            if (!resultList.Any())
            {
                Console.WriteLine("Не найдено.");
                return;
            }
            // Если есть, используем предоставленную функцию printAction
            foreach (var item in resultList)
            {
                printAction(item);
            }
        }
    }
}
