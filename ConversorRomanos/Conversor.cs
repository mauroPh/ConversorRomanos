using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorRomanos
{
    public class Conversor
    {
        private Dictionary<string, int> RomanosParaArabicos = new Dictionary<string, int>
        {
            {"I",1},
            {"IV", 4},
            {"V",5},
            {"IX",9},
            {"X",10},
            {"XL",40},
            {"L",50},
            {"XC",90},
            {"C",100},
            {"CD",400},
            {"D",500},
            {"CM",900},
            {"M",1000}
        };
        private Dictionary<int, string> _valoresInversos = new Dictionary<int, string>
       {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {40, "XL"},
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"},
            {900, "CM"},
            {1000, "M"}
        };

        public string ConversorRomanoParaArabico(string numeroRomano)
        {
            if (numeroRomano.Any(char.IsLower))
            {
                return "Erro (número romano inválido)";
            }
            int resultado = 0;

            for (int i = 0; i < numeroRomano.Length; i++)
            {
                if (i + 1 < numeroRomano.Length && RomanosParaArabicos.ContainsKey(numeroRomano.Substring(i, 2)))
                {
                    resultado += RomanosParaArabicos[numeroRomano.Substring(i, 2)];
                    i += 1;
                }
                else
                {
                    resultado += RomanosParaArabicos[numeroRomano.Substring(i, 1)];
                }
            }

            if (new Conversor().ConversorArabicoParaRomano(resultado) != numeroRomano)
            {
                return "Erro (número romano inválido)";
            }

            return resultado.ToString();
        }


        public string ConversorArabicoParaRomano(int numeroArabico)
        {
            var _valoresInversos = new Dictionary<int, string>()
{
    {10000, "X\u0305"},
    {9000, "I\u0305X\u0305"},
    {8000, "V\u0305\u0305I\u0305\u0305I\u0305\u0305I\u0305\u0305"},
    {7000, "V\u0305\u0305I\u0305\u0305I\u0305\u0305I\u0305"},
    {5000, "V\u0305"},
    {4000, "I\u0305V\u0305"},
    {1000, "M"},
    {900, "CM"},
    {500, "D"},
    {400, "CD"},
    {100, "C"},
    {90, "XC"},
    {50, "L"},
    {40, "XL"},
    {10, "X"},
    {9, "IX"},
    {5, "V"},
    {4, "IV"},
    {1, "I"}
};


            var resultado = new StringBuilder();
            foreach (var valor in _valoresInversos.Keys.OrderByDescending(v => v))
            {
                while (numeroArabico >= valor)
                {
                    resultado.Append(_valoresInversos[valor]);
                    numeroArabico -= valor;
                }
            }
            return resultado.ToString();
        }
    }
}
