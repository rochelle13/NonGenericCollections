using System.Collections;

namespace NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY LIST 
            //The array's size might change during use since it is dynamic, which implies it is not static
            //It offers functions that are comparable to those in the generic List class
           
            ArrayList NonGenericArrayList = new ArrayList();

            string str = "Like, Share, Subscribe";

            int x = 11;

            DateTime date = DateTime.Parse("4-apr-2024");

            NonGenericArrayList.Add(str);

            NonGenericArrayList.Add(x);

            NonGenericArrayList.Add(date);

            foreach (object o in NonGenericArrayList)

            {

                Console.WriteLine(o);

            }

            //HASH TABLE 
            //A hash table data structure is made up of key-value pairs
            //The hash values of the keys are compared to find the values
            //It offers functions that are comparable to those in the generic dictionary class
            Hashtable NonGenericHashTable = new Hashtable();

            NonGenericHashTable.Add(1, "Soda");

            NonGenericHashTable.Add(2, "Burger");

            NonGenericHashTable.Add(3, "Fries");

            NonGenericHashTable.Add(4, "Onion Rings");

            foreach (DictionaryEntry h in NonGenericHashTable)

            {

                Console.WriteLine(h.Key + " " + h.Value);

            }

            //SORTED LIST 
            //It is similar to the generic Sorted list, except we don't have to specify specific data type
            SortedList NonGenericSortedList = new SortedList();

            NonGenericSortedList.Add("American", "Burger");

            NonGenericSortedList.Add("Lime", "Soda");

            NonGenericSortedList.Add("French", "Fries");

            NonGenericSortedList.Add("Onion", "Rings");

            foreach (DictionaryEntry d in NonGenericSortedList)

            {

                Console.WriteLine(d.Key + " " + d.Value);

            }

            //STACK 
            //It's a LIFO (last-in, first-out) list. Hence it works similarly to the Stack class in generic collections
            Stack steak = new Stack();

            steak.Push("Rare");

            steak.Push("Medium Rare");

            steak.Push("Medium");

            steak.Push("Well done");

            foreach (object o in steak)

            {

                Console.WriteLine(o);

            }

            //QUEUE 
            //A first-in, first-out collection of items is represented by it
            //When you require first-in, first-out access to objects, you utilize it
            //It offers functions that are comparable to those in the generic Queue collection
            Queue NonGenericQueue = new Queue();

            NonGenericQueue.Enqueue("Mark");

            NonGenericQueue.Enqueue("Bill");

            NonGenericQueue.Enqueue("Xavier");

            NonGenericQueue.Enqueue("Michael");

            foreach (object o in NonGenericQueue)

            {

                Console.WriteLine(o);

            }
        }
    }
}
