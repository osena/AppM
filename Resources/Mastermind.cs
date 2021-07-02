using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMastermind.Resources
{
    class Mastermind
    {
        private readonly List<CodePeg> code;

        public Mastermind(List<CodePeg> code)
        {
            this.code = code;
        }

        public List<ResultPeg> GetHints(List<CodePeg> guess)
        {
            List<ResultPeg> listResult = new List<ResultPeg>();

            for (int i = 0; i < guess.Count; i++)
            {
                for (int e = 0; e < code.Count; e++)
                {
                    if (guess[i].Equals(code[e]) && i.Equals(e))
                    {
                        listResult.Add(ResultPeg.Black);
                    }
                    else if (guess[i].Equals(code[e]))
                    {
                        listResult.Add(ResultPeg.White);
                    }
                }
            }
            return listResult;
        }
    }
    public enum CodePeg
    {
        Black,
        Blue,
        Green,
        Red,
        White,
        Yellow,
    }

    public enum ResultPeg
    {
        Black,
        White,
    }
}
