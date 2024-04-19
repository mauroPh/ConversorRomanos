    using Xunit;
    using ConversorRomanos;

    public class ConversorTests
    {
        private readonly Conversor _conversor;

        public ConversorTests()
        {
            _conversor = new Conversor();
        }

        [Theory]
        [InlineData("XXI", "21")]
        [InlineData("LVIII", "58")]
        [InlineData("MCMXCIV", "1994")]
        [InlineData("XLIX", "49")]
        [InlineData("XD", "Erro (número romano inválido)")]
        [InlineData("ix", "Erro (número romano inválido)")]
        public void ConversorRomanoParaArabicoTest(string input, string expected)
        {
            string result = _conversor.ConversorRomanoParaArabico(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(99, "XCIX")]
        [InlineData(8932, "V̅̅I̅̅I̅̅I̅̅CMXXXII")]
        public void ConversorArabicoParaRomanoTest(int input, string expected)
        {
            string result = _conversor.ConversorArabicoParaRomano(input);
            Assert.Equal(expected, result);
        }
    }
