using Banco;
using System.ComponentModel;

namespace banco;
public class Program
{
    public static void Main()
    {

        int opcao, opcao1;
        ContaPoupanca c2 = new ContaPoupanca(); 
        ContaCorrente c1 = new ContaCorrente();
        SeguroDeVida s = new SeguroDeVida();

        do
        {
            Console.WriteLine("******BANCO******");
            Console.WriteLine("Escolha uma conta:");
            Console.Write("1 - Conta Corrente\n2 - Conta Poupança\n3 - Seguro de Vida \n0 - Sair\nResposta:");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("\nDigite:");
                        Console.Write("1 - Sacar\n2 - Depositar\n3 - Obter Saldo\n4 - Conta Corrente Tributo\n0 - Sair\nResposta:");
                        opcao1 = int.Parse(Console.ReadLine());

                        switch (opcao1)
                        {
                            case 1:
                                Console.Write("\nInforme o valor do saque:");
                                c1.ValorSaque= double.Parse(Console.ReadLine());
                                c1.Sacar(c1.ValorSaque);
                                break;
                            case 2:
                                Console.Write("\nInforme o valor do deposito:");
                                c1.ValorDeposito = double.Parse(Console.ReadLine());
                                c1.Depositar(c1.ValorDeposito);
                                break;
                            case 3:
                                c1.ObterSaldo();
                                break;
                            case 4:
                                c1.CalculaTributos();
                                break;
                            case 0:
                                Console.WriteLine("Saindo..");
                                break;
                        }
                    } while (opcao1 != 0);
                    break;
                case 2:
                    do
                    { 
                        Console.WriteLine("\nDigite:");
                        Console.Write("1 - Sacar\n2 - Depositar\n3 - Obter Saldo\n0 - Sair\nResposta:");
                        opcao1 = int.Parse(Console.ReadLine());

                        switch (opcao1)
                        {
                            case 1:
                                Console.Write("\nInforme o valor do saque:");
                                c2.ValorSaque = double.Parse(Console.ReadLine());
                                c2.Sacar(c2.ValorSaque);
                                break;
                            case 2:
                                Console.Write("\nInforme o valor do deposito:");
                                c2.ValorDeposito = double.Parse(Console.ReadLine());
                                c2.Depositar(c2.ValorDeposito);
                                break;
                            case 3:
                                c2.ObterSaldo();
                                break;
                            case 0:
                                Console.WriteLine("Saindo..");
                                break;
                        }
                    } while (opcao1 != 0);
                    break;
                case 3:
                    s.CalculaTributos();
                    break;
            }

        } while (opcao != 0);

    }
}