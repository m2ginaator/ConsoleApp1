using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Koosta neli funktsiooni, millest igaüks arvutab ja 
            //väljastab ühe geomeetrilise kujundi(ruut, 
            //ring või teemant, ristkylik, kolmnurk) 
            //kujundi "*" sümbolina(vastavalt võimalusele 
            //arvutab ja väljastab viimaks ka ümbermõõdu, 
            //pindala jne).Loo programm, mis küsib kasutajalt 
            //kujundi tüüpi sõna valikuna, kujundi andmeid
            //(vastavalt vajadusele külje pikkust, raadiust vms).
            //NB! Teemanti puhul arvutage ringi ümbermõõt ja pindala.

            Console.WriteLine("Sisesta kujund: ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "1":
                    Square();
                    break;

                case "2":
                    Teemant();
                    break;

                case "3":
                    Ristkülik();
                    break;

                case "4":
                    Kolmnurk();
                    break;

                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;
            }
        }


        private static void Square()
        {
            Console.WriteLine("Palun sisesta külje pikkus");
            int size = Convert.ToInt32(Console.ReadLine());


            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sisesta pikkus UUESTI");
            int külg = Convert.ToInt32(Console.ReadLine());
            int pindala = külg * külg;
            int ümbermõõt = 4 * külg;
            Console.WriteLine("Pindala on {0}", pindala);
            Console.WriteLine("Ümbermõõt on {0}", ümbermõõt);
        }
        private static void Teemant()
        {
            Console.WriteLine("Palun sisesta külje pikkus");
            int row = Convert.ToInt32(Console.ReadLine());
            int j;

            for (int i = 0; i <= row; i++)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = row - 1; i >= 1; i--)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Sisesta pikkus UUESTI");
            int külg = Convert.ToInt32(Console.ReadLine());
            double ümbermõõt = 2 * 3.14159265359 * külg;
            double pindala = 3.14159265359 * külg * külg;
            Console.WriteLine("Teemanti pindala on {0}", pindala);
            Console.WriteLine("Teemanti ümbermõõt on {0}", ümbermõõt);
        }
        private static void Ristkülik()
        {

            Console.Write("Sisesta külje pikkus : ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta külje laius : ");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    if ((i == 1 || i == height) || (j == 1 || j == width))
                        Console.Write("*");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sisesta pikkus UUESTi");
            int pikkus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta laius UUESTI");
            int laius = Convert.ToInt32(Console.ReadLine());
            int pindala = pikkus * laius;
            int ümbermõõt = 2 * (pikkus + laius);
            Console.WriteLine("Ristküliku pindala on {0}", pindala);
            Console.WriteLine("Ristküliku ümbermõõt on {0}", ümbermõõt);

        }
        private static void Kolmnurk()
        {
            Console.WriteLine("Sisesta kolmnurga külje suurus: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int spc = rows + 4 - 1;

            for (int i = 1; i <= rows; i++)
            {
                Console.Write("\n");
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                spc--;
            }
            Console.WriteLine("Sisesta külje suurus UUESTI : ");
            int suurus = Convert.ToInt32(Console.ReadLine());
            int pindala = (suurus * suurus) / 2;
            int ümbermõõt = suurus + suurus + suurus;
            Console.WriteLine("Kolmnurga pindala on {0}", pindala);
            Console.WriteLine("Kolmnurga ümbermõõt on {0}", ümbermõõt);

        }
    }
}



