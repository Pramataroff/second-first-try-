using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;

namespace Druj_kradeca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter type: long, int or sbyte ");
            string type = Console.ReadLine();
            Console.Write("Enter how many ID's");
            int nnum = int.Parse(Console.ReadLine());
            int id = 0;
            int difference = 0;
            int difference1 = 0;
            if (type == "sbyte")
                for (int i = 1; i <= nnum; i++)
                {
                    id = int.Parse(Console.ReadLine());

                    if (id < 128 && id > -129)
                    {
                        Console.WriteLine($"number {id} is in sbyte diapason");

                    }


                }
            else if (type == "int")
                for (int i = 1; i <= nnum; i++)
                {
                    id = int.Parse(Console.ReadLine());

                    if (id > -2147483649 && id < 2147483647)
                    {
                        Console.WriteLine($"number {id} is in int diapason");

                    }


                }
           else if (type == "long")
                for (int i = 1; i <= nnum; i++)
                {
                    id = int.Parse(Console.ReadLine());

                    if ((long)id < 2147483647 && (long)id > -2147483649)
                    {
                        Console.WriteLine($"number {(long)id} is in long diapason");

                    }


                }
        }
    }
}
