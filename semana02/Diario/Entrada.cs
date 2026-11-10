using System;

public class Entrada
{
    public string _data;
    public string _pergunta;
    public string _resposta;
    public string _humor;

    public void Exibir()
    {
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"Humor: {_humor}");
        Console.WriteLine($"Pergunta: {_pergunta}");
        Console.WriteLine($"Resposta: {_resposta}");
        Console.WriteLine();
    }
}