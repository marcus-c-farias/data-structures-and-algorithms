namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable(2);
            h.Add("grapes", 1000);
            h.Add("grapess", 1000);
            h.Add("apples", 54);
            //Console.Write(h.Get("grapess"));
            h.Print();
        }
    }
}
