namespace PyramidBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen");
            PyramidBuilder();
        }
        static void PyramidBuilder()
        {
            Console.WriteLine("Vi ska bygga en pyramid, skriv in hur många rader hög den ska vara");
            int height = int.Parse(Console.ReadLine());
            for (int row = 1; row <= height; row++)
            {
                for (int space = 0; space < height - row; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < 2  * row - 1; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
