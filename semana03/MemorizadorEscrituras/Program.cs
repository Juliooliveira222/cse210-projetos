using System;

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia =
            new Referencia("Provérbios", 3, 5, 6);

        Escritura escritura =
            new Escritura(
                referencia,
                "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento"
            );

        while (!escritura.EstaCompletamenteOculta())
        {
            Console.Clear();

            Console.WriteLine(escritura.ObterTexto());

            Console.WriteLine();
            Console.Write("Pressione Enter ou digite sair: ");

            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);
        }
    }
}