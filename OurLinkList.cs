using System;
using System.Collections.Generic;
using System.Globalization;
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
        public OurLinkList()
        {
        }


        public void Add_First(Element data)
        {
            data.NextElement = FirstElement;
            Element Temp  = new Element(data.Value,data.NextElement);
            FirstElement = Temp;
        }
        public void Remove_First()
        {
            FirstElement = FirstElement.NextElement;
        }

        public int Count()
        {
            Element currentElement = FirstElement;
            int count = 1;

            while (currentElement.NextElement != null)
            {
                currentElement = currentElement.NextElement;
                count++;
            } 

            return count;
        }
        
        public string To_String()
        {
            Element currentElement = FirstElement;
            string result = "";
            bool run = true;

            while (run)
            {        
                if (currentElement.NextElement == null)
                {
                    result = result + currentElement.Value;
                    run = false;
                }
                else
                {
                    result = result + currentElement.Value + ",";
                    currentElement = currentElement.NextElement;
                }          
            }
            return result;
        }

        public void Sort()
        {
            Element currentElement = FirstElement;
            bool run = currentElement.NextElement != null;

            while (run)
            {
                if (currentElement.NextElement == null)
                {
                    break;
                }
                if (currentElement.Value > currentElement.NextElement.Value ) 
                {
                    int temp;
                    temp = currentElement.NextElement.Value;
                    currentElement.NextElement.Value = currentElement.Value;
                    currentElement.Value = temp;
                    currentElement = FirstElement;
                } else
                {
                    if (currentElement.NextElement == null)
                    {
                        run = false;
                    }
                    else
                    {
                        currentElement = currentElement.NextElement;
                    }
                }


                
            }
        }
    }
}
