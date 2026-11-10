using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorPerguntas gerador = new GeradorPerguntas();

        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n=== MEU DIÁRIO ===");
            Console.WriteLine("1 - Escrever");
            Console.WriteLine("2 - Exibir Diário");
            Console.WriteLine("3 - Salvar Diário");
            Console.WriteLine("4 - Carregar Diário");
            Console.WriteLine("5 - Sair");

            Console.Write("\nEscolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Entrada entrada = new Entrada();

                Console.Write("Como você está se sentindo hoje? ");
                entrada._humor = Console.ReadLine();

                string pergunta = gerador.ObterPerguntaAleatoria();

                Console.WriteLine();
                Console.WriteLine(pergunta);
                Console.Write("> ");

                entrada._resposta = Console.ReadLine();

                entrada._data = DateTime.Now.ToString("dd/MM/yyyy");
                entrada._pergunta = pergunta;

                diario.AdicionarEntrada(entrada);
            }

            else if (opcao == 2)
            {
                diario.ExibirDiario();
            }

            else if (opcao == 3)
            {
                Console.Write("Nome do arquivo: ");
                string arquivo = Console.ReadLine();

                diario.SalvarArquivo(arquivo);

                Console.WriteLine("Diário salvo com sucesso!");
            }

            else if (opcao == 4)
            {
                Console.Write("Nome do arquivo: ");
                string arquivo = Console.ReadLine();

                diario.CarregarArquivo(arquivo);

                Console.WriteLine("Diário carregado com sucesso!");
            }
        }

        Console.WriteLine("Programa encerrado.");
    }
}