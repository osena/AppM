# AppM

He escrito esas lineas de codigo para un juego nombrado "MASTERMIND", para esto utilizamos listas de valores para representar las entradas y salidad de datos de la aplicacion
y bucle anidados para realizar las iteraciones de dichas listas de valores.

Para realizar las pruebas a esta app es necesario crear dos listas de valores; la primera lista corresponde al jugador que tendra la combinacion de colores secreata y la segunta
lista corresponde a el jugador que estara por adivinar la combinacion del primer jugador, para eso es necesatio instanciar la clase llamada "Mastermind.cs" que esta en el namespace 
llamado "Resources" ejemplo;


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

Puedes crear una aplicacio tanto de consola como un app de Winform o WebForm.


