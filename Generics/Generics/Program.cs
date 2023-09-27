using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenricDemo<int> genric = new GenricDemo<int>(10);
            GenricDemo<string> genri = new GenricDemo<string>("Amit");
            GenricDemo<char> genr = new GenricDemo<char>('a');
            GenricDemo<bool> gen = new GenricDemo<bool>(false);
            Console.WriteLine();
            genric.DemoMethod(10);
            genri.DemoMethod("satyam");
            genr.DemoMethod('s');
            gen.DemoMethod(true);
            Console.WriteLine();
            GenericOne one = new GenericOne();
            one.GenericOneMethod(1);
            one.GenericOneMethod(10.9);
            one.GenericOneMethod("Amit");
            one.GenericOneMethod(false);



            Console.ReadLine();

        }
    }
    
}
