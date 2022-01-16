using System;

namespace ExemploPoo.Models
{
    public class pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá. Meu Nome é {Nome} e tenho {Idade} anos.");
        }
    }
}