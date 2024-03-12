namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of the pyramid: ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(new string(' ', height - i) + new string('*', (2 * i) + 1));
            }
        }
    }
}