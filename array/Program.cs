using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alamat = new string[5]
            {
               "banyumas","sukoharjo","kejiwan","kalibeber","munggang"
            };
            Console.WriteLine(alamat[0].IndexOf('y'));
            Console.WriteLine(alamat[1].Length);
            Console.WriteLine(alamat[3].Insert(4, "mantap"));
            Console.WriteLine(alamat[0].Replace('a', 'i'));
            Console.WriteLine(string.Concat(alamat[0] + alamat[1]));
            Console.Write(string.Join("+", alamat));
            Console.ReadLine();
        }
    }
}
