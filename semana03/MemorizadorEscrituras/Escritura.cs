using System;
using System.Collections.Generic;
using System.Linq;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;
    private Random _random = new Random();

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;

        _palavras = new List<Palavra>();

        string[] palavras = texto.Split(' ');

        foreach (string palavra in palavras)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public string ObterTexto()
    {
        string textoPalavras =
            string.Join(" ", _palavras.Select(p => p.ObterTexto()));

        return $"{_referencia.ObterTexto()}\n{textoPalavras}";
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        List<Palavra> palavrasVisiveis =
            _palavras.Where(p => !p.EstaOculta()).ToList();

        for (int i = 0;
             i < numeroParaOcultar && palavrasVisiveis.Count > 0;
             i++)
        {
            int indice = _random.Next(palavrasVisiveis.Count);

            palavrasVisiveis[indice].Ocultar();

            palavrasVisiveis.RemoveAt(indice);
        }
    }
}