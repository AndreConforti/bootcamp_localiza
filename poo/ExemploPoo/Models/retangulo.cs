namespace ExemploPoo.Models
{
    public class retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;



        public void definirmedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento =  comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores inválidos");
                valido = false;
            }
        }

        public double obterarea()
        {
            if (valido)
            {
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Preencha com valores válidos");
                return 0;
            }
        }
    }
}