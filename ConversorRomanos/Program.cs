using ConversorRomanos;
using System;

public class Program
{
    public static void Main()
    {
        // Entrada: "XXI"
        // Saída esperada: 21

        //Entrada: "LVIII"
        //Saída esperada: 58

        //Entrada: "MCMXCIV"
        //Saída esperada: 1994

        //Entrada: "XLIX"
        //Saída esperada: 49

        //Entrada: "XD"
        //Saída esperada: Erro(número romano inválido)

        //Entrada: "ix"
        //Saída esperada: Erro(número romano inválido)

        //Entrada: "99"
        //Saída esperada: XCIX

        //Entrada: "8932"
        //Saída esperada: VIIICMXXXII

        Conversor conversor = new Conversor();
        Console.WriteLine(conversor.ConversorRomanoParaArabico("XXI"));
        Console.WriteLine(conversor.ConversorRomanoParaArabico("LVIII"));
        Console.WriteLine(conversor.ConversorRomanoParaArabico("MCMXCIV"));
        Console.WriteLine(conversor.ConversorRomanoParaArabico("XLIX"));
        Console.WriteLine(conversor.ConversorRomanoParaArabico("XD"));
        Console.WriteLine(conversor.ConversorRomanoParaArabico("ix"));
        Console.WriteLine(conversor.ConversorArabicoParaRomano(99));
        Console.WriteLine(conversor.ConversorArabicoParaRomano(8932));


    }
}
