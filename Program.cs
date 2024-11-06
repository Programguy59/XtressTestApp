namespace XtressTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurLinkList linkList = new OurLinkList(new Element(1, null));
            Element element2 = new Element(2, null);
            Element element3 = new Element(3, null);
            Element element4 = new Element(4, null);

            linkList.Add_First(element4);
            linkList.Add_First(element2);
            linkList.Add_First(element3);

            linkList.Sort();

            string test = linkList.To_String();
            Console.ReadLine();
        }
    }
}
