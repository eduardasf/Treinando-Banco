

namespace banco
{
    public class ContaCorrente : Conta, ITributavel
    {
        public void CalculaTributos()
        {
            double imposto;
            imposto = this.Saldo * 1 / 100;
            Console.WriteLine("O valor do imposto é "+  imposto +" Reais");
        }
    }
}
