using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtressTestApp
{
    public class Element
    {
        public int Value;
        public Element NextElement;
        public Element(int value, Element nextElement)
        {
            Value = value;
            NextElement = nextElement;
        }
        
    }

    
}
