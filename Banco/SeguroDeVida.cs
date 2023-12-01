
using banco;
using System.Reflection.Metadata.Ecma335;

namespace Banco
{
    public class SeguroDeVida : ITributavel
    {
        public void CalculaTributos()
        {
            double sVida = 42;
            Console.WriteLine("\nO seguro de vida é " + sVida +" Reais.");
        }
    }
}
