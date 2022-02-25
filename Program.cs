using System;
using orientacao_a_objetos.src.Entities;

namespace orientacao_a_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenuca", 23, "White Wizard");
            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
