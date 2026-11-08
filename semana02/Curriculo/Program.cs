using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Cronoanalista";
        emprego1._empresa = "Ipatinga LTDA";
        emprego1._anoInicio = 2013;
        emprego1._anoFim = 2018;

        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Mecanico Montador Diesel";
        emprego2._empresa = "Cdiesel";
        emprego2._anoInicio = 2020;
        emprego2._anoFim = 2024;

        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Mecanico Montador de Aeronaves";
        emprego2._empresa = "Embraer";
        emprego2._anoInicio = 2024;
        
        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nome = "Julio Oliveira";

        meuCurriculo._empregos.Add(emprego1);
        meuCurriculo._empregos.Add(emprego2);

        meuCurriculo.Exibir();
    }
}