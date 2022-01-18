using System;

namespace ExemploPoo.Models
{
    public class diretor : professor
    {   
        public override void Apresentar()  // a propriedade sealed trava o método e não pode herdar para classes filhas
        {
            Console.WriteLine($"Diretor");
        }
    }
}