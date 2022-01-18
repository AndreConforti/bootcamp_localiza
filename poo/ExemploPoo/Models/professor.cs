namespace ExemploPoo.Models
{
    public class professor : pessoa
    {
        public double salario { get; set; }
        public override void Apresentar() // Se eu usar a propriedade sealed ele trava o método não podendo herdar para a classe filha diretor
        {
            Console.WriteLine($"Olá. Meu Nome é {Nome}, tenho {Idade} anos e meu salário é de R$ {salario}");
        }
    }
}