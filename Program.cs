using AppMastermind.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMastermind
{
    class Program
    {
        static void Main(string[] args)
        {


            List<CodePeg> listCodePeg = new List<CodePeg>();
            listCodePeg.Add(CodePeg.Blue);
            listCodePeg.Add(CodePeg.Green);
            listCodePeg.Add(CodePeg.Red);
            listCodePeg.Add(CodePeg.Yellow);

            Mastermind masterMind = new Mastermind(listCodePeg);



            List<CodePeg> listGess = new List<CodePeg>();
            listGess.Add(CodePeg.Black);
            listGess.Add(CodePeg.Yellow);
            listGess.Add(CodePeg.Red);
            listGess.Add(CodePeg.Blue);

            List<ResultPeg> listResultPeg = masterMind.GetHints(listGess);

            for (int i = 0; i < listResultPeg.Count; i++)
            {
                Console.Write("{0}", listResultPeg[i].ToString());
            }

            Console.ReadLine();

        }
    }
}
