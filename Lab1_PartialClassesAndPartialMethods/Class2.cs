using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_PartialClassesAndPartialMethods
{
    //contains partial class1
    public partial class Class1
    {
        public Class1()
        {
            //calling partial method
            someOneWillImplement();
        }
        public void method5()
    {
        Console.WriteLine("class1|method5");
    }
        public void method6()
    {
        Console.WriteLine("class1|method6");
    }
        public void method7()
    {
        Console.WriteLine("class1|method7");
    }
        public void method8()
    {
        Console.WriteLine("class1|method8");
    }

        partial void someOneWillImplement() //partial method is private implicitly
        {
            Console.WriteLine("partial method implementation");
        }

    }
}
