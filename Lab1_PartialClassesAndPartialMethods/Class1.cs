using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PartialClassesAndPartialMethods
{
    //Partial Class = helps you define classes in 2 physical files
    public partial class Class1
    {
        public void method1()
        {
            Console.WriteLine("class1|method1");
        }
        public void method2()
        {
            Console.WriteLine("class1|method2");
        }
        public void method3()
        {
            Console.WriteLine("class1|method3");
        }
        public void method4()
        {
            Console.WriteLine("class1|method4");
        }

        //partial methods - definition in one file and implementation of that method in another file
        partial void someOneWillImplement(); //defintion -- can NOT have modfiers like public, virtual, abstract, override
    }
}
