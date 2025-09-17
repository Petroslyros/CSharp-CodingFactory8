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
            int.listLength = intList.Count;


            int num = intList[1]; //read
            intList[1] = 10;        //update
        }
    }
}
