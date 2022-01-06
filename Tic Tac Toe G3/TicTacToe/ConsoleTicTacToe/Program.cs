using System;
using Business.Models;

namespace ConsoleTicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Match match = new Match();
            Console.WriteLine(match.PlayGame(0, 1));
            Console.WriteLine(match.PlayGame(0, 0));
            Console.WriteLine(match.PlayGame(1, 1));
            Console.WriteLine(match.PlayGame(0, 2));
            Console.WriteLine(match.PlayGame(1, 2));
            Console.WriteLine(match.PlayGame(1, 0));
            Console.WriteLine(match.PlayGame(2, 0));
            Console.WriteLine(match.PlayGame(2, 1));
            Console.WriteLine(match.PlayGame(2, 2));
           // Console.WriteLine(match.PlayGame(1, 3));



        }
    }
}
