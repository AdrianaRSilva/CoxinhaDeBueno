﻿using System;
class Desafio
{
    static void Main()
    {
        string[] linha = Console.ReadLine().Split(' ');

        double coxinha = double.Parse(linha[0]);
        double participantes = double.Parse(linha[1]);
        double mediaCoxinhas = (coxinha / participantes);
        Console.WriteLine(" " + mediaCoxinhas.ToString("F2"));
    }
}


