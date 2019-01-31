using System;
using System.Linq;

namespace CS.Impl
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            String text = string.Join(" ", sentence.Split(' ').Reverse());
            return text;
        }
    }
}
