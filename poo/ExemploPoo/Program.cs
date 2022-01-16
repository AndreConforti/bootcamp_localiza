using System;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno p1 = new aluno();
            p1.Nome = "André";
            p1.Idade = 43;
            p1.nota = 7;
            p1.Apresentar();
            System.Console.WriteLine($"Minha nota é {p1.nota}");















            // // Valores válidos
            // retangulo r = new retangulo();
            // r.definirmedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.obterarea()}");

            // // Valores inválidos
            // retangulo r2 = new retangulo();
            // r.definirmedidas(0, 0);
            // System.Console.WriteLine($"Área: {r.obterarea()}");
            
            
            
            
            
            
            // pessoa p1 = new pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}
