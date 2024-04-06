namespace StarPattern
{
    internal class Program
    {
        private void PyramidPattern()
        {
            //Console.WriteLine("Enter the value of n");

            //int n = Convert.ToInt32(Console.ReadLine());

            //Here n represents number of rows.
            int n = 5;

            //Right Half pyramid
            Console.WriteLine("------------------Right Half Pyramid Pattern----------------------------");
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------Inverted Right Half Pyramid Pattern-------------------------");

            for (int i = 0; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------Left Half Pyramid Pattern--------------------------");

            n = 10;
            for (int i = 0; i <= n; i++)
            {
                // loop for printing leading whitespaces 
                for (int j = 0; j < 2 * (n - i) - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------Inverted Left Half Pyramid Pattern-------------------------");
            // first loop for printing all rows 
            for (int i = 0; i < n; i++)
            {

                // first inner loop for printing white spaces 
                for (int j = 0; j < 2 * i; j++)
                {
                    Console.Write(" ");
                }

                // second inner loop for printing star * 
                for (int k = 0; k < n - i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------Full Pyramid Pattern--------------------------");

            n = 10;
            for (int i = 0; i <= n; i++)
            {
                // loop for printing leading whitespaces 
                for (int j = 0; j < 2 * (n - i) - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------Inverted full Pyramid Pattern-------------------------");
            // first loop for printing all rows 
            for (int i = 0; i < n; i++)
            {

                // first inner loop for printing white spaces 
                for (int j = 0; j < 2 * i; j++)
                {
                    Console.Write(" ");
                }

                // second inner loop for printing star * 
                for (int k = 0; k < 2 * (n - i) - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PyramidPattern();
            Console.ReadLine();
        }
    }
}
