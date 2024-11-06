using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtressTestApp
{
    public class OurLinkList
    {
        public Element FirstElement;
        public OurLinkList(Element firstElement) 
        {
            FirstElement = firstElement;
        }
        

        public void Add_First(Element data)
        {
            data.NextElement = FirstElement;
            FirstElement = data;
        }
        public void Remove_First()
        {
            FirstElement = FirstElement.NextElement;
        }

        public int Count()
        {
            Element currentElement = FirstElement;
            int count = 0;

            do
            {
                currentElement = currentElement.NextElement;
                count++;
            } while (currentElement.NextElement != null);

                return count;
        }
        
        public string To_String()
        {
            return "Hello wrld";
        }

        public void Sort()
        {

        }
    }
}
