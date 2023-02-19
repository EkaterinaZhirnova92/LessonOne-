using System; //базовое пространство имен
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LessonOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите число в форме строки: ");
            string numberString = ReadLine();
            int number = Convert.ToInt32(numberString);
            WriteLine("Строка 23 переведена в число " + number);
            int number1 = Int32.Parse(numberString);  //parse выполняется быстрее, работает со строками

        }
    }
}
