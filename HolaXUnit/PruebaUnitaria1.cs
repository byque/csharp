namespace HolaXUnit
{
    public class PruebaUnitaria1
    {
        /*
         * Facts: pruebas que siempre son verdaderas. Prueban condiciones
         *        invariantes.
         *
         * Theories: pruebas que solo son verdaderas para un conjunto de datos
         *           particular.
         */

        [Fact]
        public void PruebaPasa()
        {
            Assert.Equal(4, Sumar(2, 2));
        }

        [Fact]
        public void PruebaFalla()
        {
            Assert.Equal(5, Sumar(2, 2));
        }

        int Sumar(int x, int y)
        {
            return x + y;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void PrimeraTeoria(int valor)
        {
            Assert.True(EsImpar(valor));
        }

        bool EsImpar(int valor)
        {
            return valor % 2 == 1;
        }
    }
}
