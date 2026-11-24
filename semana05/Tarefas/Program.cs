using System;

class Program
{
    static void Main(string[] args)
    {
        Tarefa t1 = new Tarefa("Samuel Bennett", "Multiplicação");
        Console.WriteLine(t1.ObterResumo());

        TarefaDeMatematica t2 = new TarefaDeMatematica("Roberto Rodriguez", "Frações", "7.3", "8-19");
        Console.WriteLine(t2.ObterResumo());
        Console.WriteLine(t2.ObterListaDeTarefas());

        TarefaDeRedacao t3 = new TarefaDeRedacao("Mary Waters", "História Européia", "As Causas da Segunda Guerra Mundial");
        Console.WriteLine(t3.ObterResumo());
        Console.WriteLine(t3.ObterInformacaoDaRedacao());
    }
}