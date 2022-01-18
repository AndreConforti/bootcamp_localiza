namespace ExemploPoo.Models
{
    public class corrente : conta
    {
        public override void creditar(double valor)
        {
            base.saldo = valor; // significa q base está alterando o valor da propriedade saldo na classe mãe conta
        }
    }
}