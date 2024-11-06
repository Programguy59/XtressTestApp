namespace XtressTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurLinkList linkList = new OurLinkList(new Element(1, null));
            Element element = new Element(5, null);

            linkList.Add_First(element);
            linkList.Add_First(element);
            linkList.Add_First(element);
            linkList.Add_First(element);

            linkList.Count();
            Console.ReadLine();
        }
    }
}
