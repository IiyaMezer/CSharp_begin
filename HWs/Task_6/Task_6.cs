namespace Task_6
{
    internal class Task_6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the num: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}