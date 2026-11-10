
using System;
using System.Collections.Generic;
using System.IO;

public class Diario

{

    public List<Entrada> _entradas = new List<Entrada>();

    public void AdicionarEntrada(Entrada entrada)
    {
        _entradas.Add(entrada);
    }

    public void ExibirDiario()
    {
        foreach (Entrada entrada in _entradas)
        {
            entrada.Exibir();
        }
    }

    public void SalvarArquivo(string nomeArquivo)
{
    using (StreamWriter writer = new StreamWriter(nomeArquivo))
    {
        foreach (Entrada entrada in _entradas)
        {
            writer.WriteLine(
                $"{entrada._data}|{entrada._humor}|{entrada._pergunta}|{entrada._resposta}"
            );
        }
    }
}

    public void CarregarArquivo(string nomeArquivo)
{
    _entradas.Clear();

    string[] linhas = File.ReadAllLines(nomeArquivo);

    foreach (string linha in linhas)
    {
        string[] partes = linha.Split('|');

        Entrada entrada = new Entrada();

        entrada._data = partes[0];
        entrada._humor = partes[1];
        entrada._pergunta = partes[2];
        entrada._resposta = partes[3];

        _entradas.Add(entrada);
    }
}
}