using System;

namespace projetoreferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Valor valor = new Valor();

            int n = 5;
            valor.passagemPorValor(n);
            Console.WriteLine("Por valor: " + n);

            valor.passagemPorReferencia(ref n);
            Console.WriteLine("Por referencia: " + n);

            Console.ReadLine();
        }
    }
}
