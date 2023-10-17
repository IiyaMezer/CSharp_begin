namespace HW_1
{
    internal class Task_2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st num: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the 2nd num: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"max = {a} ");
            }
            else if (b > a)
            {
                Console.WriteLine($"max = {b}");
            }
            else
            {
                Console.WriteLine($"Equal nums");
            }
            Console.ReadKey();
        }
    }
}
