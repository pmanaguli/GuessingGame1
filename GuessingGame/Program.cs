using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using GuessingGame;
using GuessingGame.Generators;

namespace GuessingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
             INumberGenerator numberGenerator = new RandomNumberGenerator();
            Service result=new Service(numberGenerator);          
            Console.WriteLine("Welcome to the Guessing Game!");
             var level=result.GetLevel();
        
        }
    }
}











