namespace PlayWithTypes
{
    internal class TestIndexer
    {
        public void TestIndexersInCollection()
        {
            // If you want to access a specific card, you can go through the Cards property to access it,
            //but this is not always convenient. That’s why C# has indexer properties. An indexer property
            //allows your class to be accessed with an index, just like a regular array.An example of an
            //indexer property in the.NET Framework can be found in the List<T> collection type.

            // Declare an instance of the SampleCollection type.
            SampleCollection<string> stringCollection = new SampleCollection<string>();

            // Use [] notation on the type.
            stringCollection[0] = "Hello, World using Indexor from position 0.";
            System.Console.WriteLine(stringCollection[0]);

        }


    }

    public class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer, which will allow client code
        // to use [] notation on the class instance itself.
        // (See line 2 of code in Main below.)        
        public T this[int i]
        {
            get
            {
                // This indexer is very simple, and just returns or sets
                // the corresponding element from the internal array.
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
    }
}