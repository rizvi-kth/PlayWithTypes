using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {


            TestIndexer tx = new TestIndexer();
            tx.TestIndexersInCollection();

            TestConstructor tc = new TestConstructor();
            tc.TestDiffConstructorParam();




        }
    }

    
}
