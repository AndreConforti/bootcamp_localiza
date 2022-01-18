namespace ExemploPoo.Models
{
    public class aluno : pessoa
    {
        public int nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá. Meu Nome é {Nome}, tenho {Idade} anos e minha nota é {nota}");
        }
    }
}