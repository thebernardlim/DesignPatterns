using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory #1 - EnglishGameFactory
            Console.WriteLine("Initiate English Game");
            GameFactoryAbstract englishGameFactory = new GameFactoryEnglish();
            Client englishGame = new Client(englishGameFactory);
            englishGame.Run();

            // Abstract factory #2 - JapGameFactory
            Console.WriteLine("Initiate Japanese Game");
            GameFactoryAbstract japGameFactory = new GameFactoryJap();
            Client japGame = new Client(japGameFactory);
            japGame.Run();

            // Wait for user input
            Console.ReadKey();

        }
    }
}
