using System;

namespace ExemploPoo.Models
{
    public class pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }
        public string documento { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá. Meu Nome é {Nome} e tenho {Idade} anos.");
        }
    }
}