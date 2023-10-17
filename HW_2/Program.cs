namespace HW_2;

class Program
{
    static void Main(string[] args)
    {
        bool f = true;
        while (f)
        {
            Console.WriteLine("Выберите задачу:");
            Console.WriteLine(
                "1 - Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
            Console.WriteLine(
                "2 - Задача 13.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
            Console.WriteLine(
                "3 - Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
            Console.WriteLine("0 - Выход");
            Console.WriteLine("===================");
            int TaskNum = Convert.ToInt32(Console.ReadLine());
            switch (TaskNum)
            {
                case 1:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 10 Вторая цифра числа");
                    Console.WriteLine("========================");
                    Task10();
                    Console.WriteLine("========================");
                    break;

                case 2:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 13 Третья цифра числа с условием");
                    Console.WriteLine("========================");
                    Task13();
                    Console.WriteLine("========================");
                    break;

                case 0:
                    f = false;
                    Console.WriteLine("========================");
                    Console.WriteLine("Звершение работы");
                    Console.WriteLine("========================");
                    Console.ReadKey();
                    break;



                case 3:
                    Console.WriteLine("========================");
                    Console.WriteLine("Задача 15 День недели");
                    Console.WriteLine("========================");
                    Task15();
                    Console.WriteLine("========================");
                    break;

            }
        }
    }

    private static void Task10()
    {
        Console.Write("Enter the num");
        string a = Console.ReadLine() ;
        TheSecondNum(a);
    }

    private static void TheSecondNum(string? s)
    {
        if (s.Length != 3)
        {
            Console.WriteLine("Ведено не трехзначное число.");
        }
        Console.WriteLine(s[1]);
    }

    private static void Task13()
    {
        Console.Write("Enter the num");
        string a = Console.ReadLine();
        TheЕршквNum(a);
    }

    private static void TheЕршквNum(string? s)
    {
        if (s.Length < 3)
        {
            Console.WriteLine("Третьей цифры нет.");
        }
        Console.WriteLine(s[2]);
    }

    private static void Task15(string a)
    {
 
    }
}
