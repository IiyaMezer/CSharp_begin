namespace Task_8
{
    internal class Task_8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the num: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int temp = 2;

            while (temp <= a)
            {
                Console.Write($"{temp} ");
                temp+=2;
            }
        }
    }
}