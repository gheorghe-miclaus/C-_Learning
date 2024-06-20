using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace Coding.Exercise_2
{
    public class Exercise_2
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            //your code goes here
            var result = new List<string>();
            var rr = new List<string> { };
            foreach (var word in words)
            {
                var checkCase = false;

                if (result.Contains(word)) { continue; };

                foreach (char c in word)
                {
                    if (char.IsLower(c) || !char.IsLetter(c))
                    {
                        checkCase = true;
                        break;
                    };
                }
                if (!checkCase) { result.Add(word); };


            }
            return result;
        }
    }
}