namespace PyramidBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //välkomstmeddelande och anropa metoden PyramidBuilder
            Console.WriteLine("Välkommen");
            PyramidBuilder();
        }
        static void PyramidBuilder()
        {
            //gör en int för att spara hur hög användaren vill att pyramiden ska vara
            Console.WriteLine("Vi ska bygga en pyramid, skriv in hur många rader hög den ska vara");
            int height = int.Parse(Console.ReadLine());

            // yttre loopen gör att den börjar på 1 och lägger på en så länge höjden är större eller samma som row. den kör alltså en gång för varje rad i pyramiden
            for (int row = 1; row <= height; row++)
            {
                // skriver ut mellanslag så att pyramiden blir centrerad och den lägger till mellanslag ju högre upp i pyramiden man kommer
                for (int space = 0; space < height - row; space++)
                {
                    Console.Write(" ");
                }
                // skriver ut stjärnorna som bygger pyramiden. då använder man funktionen 2*n-1, där n är min row
                for (int star = 0; star < 2  * row - 1; star++)
                {
                    Console.Write("*");
                }
                // börjar på en ny rad efter föregående rad är klar
                Console.WriteLine();
            }
        }
    }
}
