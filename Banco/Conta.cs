
namespace banco
{
    public abstract class Conta
    {
        public double Saldo { get; set; }
        public double ValorSaque { get; set; }
        public double ValorDeposito { get; set; }


        public void Sacar(double ValorSaque)
        {
            if (Saldo > 0 && Saldo >= ValorSaque)
            {
                this.Saldo -= this.ValorSaque;
                Console.WriteLine("Saque no valor de " + ValorSaque + " Reais realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível realizar o saque! Saldo insuficiente!");
            }
        }

        public void Depositar(double ValorDeposito)
        {
            this.Saldo += ValorDeposito;
            Console.WriteLine("Deposito no valor de " + ValorDeposito + " Reais realizado com sucesso!");
        }

        public void ObterSaldo()
        {
            Console.WriteLine("O saldo da sua conta é:" + this.Saldo);
        }


    }
}
