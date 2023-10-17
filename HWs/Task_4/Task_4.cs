namespace Task_4
{
    internal class Task_4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st num: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd num: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd num: ");
            int c = Convert.ToInt32(Console.ReadLine());



            if (a > b || a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a || b > c)
            {
                 Console.WriteLine( b );
            }
            else if (c > a || c > b)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}