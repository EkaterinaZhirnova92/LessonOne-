using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LessonOne
{
    internal class Program
    {
        static void startQuiz()
        {
            string[] questions =
                {
                "Самая высокая гора? ",
                "Самая длинная река? ",
                "Самая большая страна? ",
                "Самое большое озеро? "
                };
            string[] answers = { "эверест", "амазонка", "россия", "байкал" };
            int countOfRightAnswers = 0;
            string userAnswer;
            for (int i = 0; i < questions.Length; i++)
            {
                Write(questions[i]);
                userAnswer = ReadLine();
                if (userAnswer.ToLower() == answers[i])
                {
                    countOfRightAnswers++;
                    WriteLine("Ответ верный!");
                }
                else
                {
                    WriteLine("Ответ неверный!");
                }
            }
            WriteLine("правильных ответов: " + countOfRightAnswers);
            if(countOfRightAnswers ==4)
            {
                WriteLine(" Отличный результат! ");
            }
            else if(countOfRightAnswers == 3)
            {
                WriteLine(" Хорошо, но можно лучше!");
            }
            else
            {
                WriteLine(" Надо повторить географию!");
            }
        }

        static void guessNumber()
        {
            WriteLine("Угадай число от 0 до 100 ");
            Random rand = new Random();
            int magicNumber = rand.Next(0, 100);
            int numberOfPlayer = 0;
            int count = 7;
            int countTrying = 0;
            do
            {
                if (count == 0)
                {
                    WriteLine("Увы, твои попытки закончились!");
                    break;
                }
                else
                {
                    Write($"У тебя {count} попыток. Введи число: ");
                numberOfPlayer = Int32.Parse(ReadLine());
                    countTrying++;
                    if (numberOfPlayer > magicNumber)
                    {
                        WriteLine("Число меньше загаданного! ");
                    }
                    else if (numberOfPlayer < magicNumber)
                    {
                        WriteLine("Число больше загаданного! ");
                    }
                    else if (numberOfPlayer == magicNumber)
                    {
                        WriteLine("Ты угадал число! Оно равно " + magicNumber);
                        WriteLine($"Тебе понадобилось {countTrying} попыток");
                    }
                    count--;
                }
            }
            while (numberOfPlayer != magicNumber);
        }
        static void Main(string[] args)
        {
            int numberOfUser =0;
            while (numberOfUser != 1) 
            { 
                WriteLine("Введите число для выбора игры: 1 - викторина, 2 - угадай число");
                int answer = Int32.Parse(ReadLine());
                switch (answer)
                {
                    case 1:
                        startQuiz();
                        break;
                    case 2:
                        guessNumber();
                        break;
                }
                WriteLine("\n---------------Нажмите на 1, если хотите выйти и на любую другую цифру для возвращения в меню---------------");
                numberOfUser = Int32.Parse(ReadLine());
            };
        }
    }
}
