using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //Generics means single form
    //It doesnot specify a particular Datatype
    //Generic allow us asingle class or method that can be used to different datatypes
    //<Type> with Type Name
    //Type parameter
    internal class GenricDemo <T>
    {
        //public string data;
        public T data;
        public GenricDemo(T data)
        {
            this.data = data;
            Console.WriteLine(this.data);


        }
        public void DemoMethod(T num)
        {
            Console.WriteLine(num);
        }
    }
    public class GenericOne
    {
        public void GenericOneMethod<T>(T info) 
        {
            Console.WriteLine(info);
        }
    }
}
