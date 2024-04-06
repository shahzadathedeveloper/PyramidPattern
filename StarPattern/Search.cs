using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    internal class Search
    {
        int[] elements = new int[] { 2,5,7,8 };
        
        public string SearchElement(int valueToFind)
        {
            for (int i = 0;i<elements.Length;i++)
            {
                if (elements[i] == valueToFind)
                    return $"{valueToFind} found at {i} Index";
                 
            }
            return "element not found";
        }

    }
}
