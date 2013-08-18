using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefinitionExtension
{
    public class Signal : IComparable
    {
        public Char Name { get; set; }

        public List<Char> Positives = new List<char>();

        public List<Char> Negatives = new List<char>();

        public int CompareTo(object obj)
        {
            Char other = (Char)obj;

            if (this.Name < other)
            {
                return 1;
            }
            else if (this.Name > other)
            {
                return -1;
            }
            else
                return 0;

        }
    }
}
