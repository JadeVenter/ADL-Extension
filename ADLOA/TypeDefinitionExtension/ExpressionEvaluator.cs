using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtension
{
    public static class ExpressionEvaluator
    {
        private static bool isSignal(Char val)
        {
            return (Char.IsLetter(val));
        }

        public static List<Signal> evaluate(String expression){
            List<Signal> results = new List<Signal>();
            expression = expression.Replace(" ","");
            String left = expression.Substring(0, expression.IndexOf('=') );
            String right = expression.Substring(expression.IndexOf('=') + 1);
            Signal current = null;

            for (int i = 0; i < left.Length; i++)
            {
                if (ExpressionEvaluator.isSignal(left[i]))
                {
                    current = (from a in results where (a.CompareTo(left[i]) == 0) select a).SingleOrDefault();
                    if (current == null)
                    {
                        current = new Signal() { Name = left[i] };
                        results.Add(current);
                    }
                    

                    for (int j = 0; j < right.Length; j++)
                    {
                        if (ExpressionEvaluator.isSignal(right[j]))
                        {
                            if (j != 0 && right[j - 1].Equals('-'))
                                current.Negatives.Add(right[j]);
                            else
                                current.Positives.Add(right[j]);
                        }
                    }
                    
                }

            }
            
            return results;
        }

    }
}
