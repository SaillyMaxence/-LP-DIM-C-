using System;
using System.Collections.Generic;

namespace CS.Impl
{
    public class Math
    {
        public int Sum (int x, int y)
        {
            return x + y;
        }

        public int Divide (int dividende, int diviseur)
        {
            return (dividende / diviseur);
        }

        public int SumTable(List<int> listeEntier)
        {
            int max = listeEntier.Count;
            int sum = 0;
            for (var i = 0; i< max; i++){
                sum += listeEntier[i];
            }
            return sum;
        }
    }
}
