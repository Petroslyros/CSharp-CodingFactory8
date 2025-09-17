using CollectionsApp2.model;
using System.Threading.Channels;

namespace CollectionsApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>();
            intList.Add(1);
            intList.AddRange(new[] { 2, 3 });
            intList.Insert(index: 0, item: 1);
            intList.Remove(item: 1);
            intList.RemoveAt(index: 1);
            intList.Reverse();
            intList.Sort();
            intList.Contains(0);
            int listLength = intList.Count;


            int num = intList[1]; //read
            intList[1] = 10;        //update
            intList.ForEach(item => Console.WriteLine(item));

            //LinkedList
            var list = new LinkedList<string>();
            var item1 = list.AddFirst("CF1");
            var item2 = list.AddBefore(item1, "CF0");
            var item3 = list.AddAfter(item2, "CF2");
            list.AddLast("AUEB");

            list.Last!.Previous!.Previous!.Value = "Factory";

            foreach (string str in list)
            {
                Console.Write(str + " ");
            }

            //dictionaries
            var words = new Dictionary<int, string>() { { 1, "Hello" }, { 2, "World" } };
            words.Add(1, "Hello");
            words[2] = "AUEB";
            words[2] = "Coding";
            words.Remove(1);

            foreach (var keyValue in words)
            {
                Console.WriteLine($"Key: {keyValue.Key}, Value: {keyValue.Value}");
            }

            //stack -- lifo
            var stack = new Stack<string>();
            stack.Push("AR1980");
            stack.Push("BR222");
            var lastCar = stack.Pop();
            foreach (var car in stack)
            {
                Console.WriteLine(car);
            }


            //queues -- fifo
            var queue = new Queue<string>();
            queue.Enqueue("AR1980");
            queue.Enqueue("BR222");
            queue.Enqueue("AR1981");
            var firstcar = queue.Dequeue();
            foreach (var car in stack)
            {
                Console.WriteLine(car);
            }

            //set 
            var s1 = new SortedSet<string>() { "Coding", "Factory", "AUEB" }; //collection initializer
            var s2 = new HashSet<string>() { "Coding", "Factory", "World" };
            s1.Add("Hello");
            s2.Add("World");        // no duplicates

            s1.ExceptWith(s2);
            s1.UnionWith(s2);
            foreach (string word in s1)
            {
                Console.Write(word + " ");
            }

            //Products
            List<Product> products = new()
            {
                new Product() { Description = "Milk", Price = 10, Quantity = 20 },
                new Product() { Description = "Honey", Price = 20.5, Quantity = 18 },
                new Product() { Description = "Eggs", Price = 4.5, Quantity = 20 },
            };
            products.Sort();
            products.ForEach(Console.WriteLine);

            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            products.ForEach(Console.WriteLine);

            products.Sort((p1, p2) => p1.Quantity - p2.Quantity);
            products.ForEach(Console.WriteLine);

        }
    }

}