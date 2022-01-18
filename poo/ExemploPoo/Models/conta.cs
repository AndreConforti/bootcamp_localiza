namespace ExemploPoo.Models
{
    public abstract class conta
    {
        protected double saldo;
        public abstract void creditar(double valor);
        public void exibirsaldo()
        {
            System.Console.WriteLine("Seu saldo é: R$ "+ saldo);
        }

    }
}