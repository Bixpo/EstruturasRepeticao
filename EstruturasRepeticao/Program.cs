using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EstruturasRepeticao

{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //        // continue;
            //        break;
            //    Console.WriteLine(i);
            //}

            //foreach (var item in DriveInfo.GetDrives())
            //{
            //    Console.WriteLine(item.Name);
            //}

            int i = 0;

            do
            {
                Console.WriteLine(i);
                continue;
                break;
                i++;
            } while (i < 0);

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
