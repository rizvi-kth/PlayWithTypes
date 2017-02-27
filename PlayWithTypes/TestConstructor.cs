using System;

namespace PlayWithTypes
{
    internal class TestConstructor
    {
        public void TestDiffConstructorParam()
        {
            
            // OPTIONAL AND NAMED PARAMETERS IN CONSTRUCTORS

            // Using optional arguments in constructors
            A a = new A();
            Console.WriteLine("\nPopulated with optional arguments - a.param1:{0} and a.param2:{1}", a.param1, a.param2);

            // Using named arguments in constructors
            A a1 = new A(pram2:10);
            Console.WriteLine("\nPopulated with named arguments - a1.param1:{0} and a1.param2:{1}", a1.param1, a1.param2);

            // Using Constructor chaining
            Console.WriteLine("\n");
            B b = new B();
            Console.WriteLine("Using Constructor chaining - b.param1:{0} and b.param2:{1}", b.param1, b.param2);


        }
    }

    public class A
    {
        public int param1 = 0;
        public int param2 = 0;

        public A(int pram1 = 1, int pram2 = 2)
        {
            this.param1 = pram1;
            this.param2 = pram2;
        }
    }

    public class B
    {
        public int param1 = 0;
        public int param2 = 0;

        public B():this(100)
        {
            Console.WriteLine("This is default constructor");
        }
        public B(int pram1) : this(200, 300)
        {
            Console.WriteLine("This is 1st chain constructor");
        }

        public B(int pram1 , int pram2)
        {
            Console.WriteLine("This is 2nd chain constructor");

            this.param1 = pram1;
            this.param2 = pram2;
        }
    }




}