using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanjebr3
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int[] arr = new int[100];
            KlasaX x = new KlasaX(arr);
            for (int index = 0; index < 100; index++)
            {
                arr[b] = index;
                b++;
                if (index == 50)
                {
                    Console.WriteLine(arr[index]);
                }
            }


            Console.ReadKey();
        }
    }
    class KlasaX
    {
        int[] arr = new int[100];

        public KlasaX(int[] arr)
        {
            this.arr = arr;

        }

        public void setarr(int[] arr)
        {
            this.arr = arr;
        }

        public int[] getarr()
        {
            return this.arr;
        }
    }
}
