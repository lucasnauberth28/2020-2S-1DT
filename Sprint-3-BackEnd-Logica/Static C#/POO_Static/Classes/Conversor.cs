namespace POO_Static.Classes
{
      public static class Conversor
    {
        private static float cotacaoDolar = 5.10f;

        private static float cotacaoEuro = 6.22f; 
        public static float valorUsuario;
        public static float ConverterDolarParaReal(){
            return valorUsuario * cotacaoDolar;
        }
        public static float ConverterRealParaDolar(){
            return valorUsuario / cotacaoDolar;
        }

        public static float CoverterEuroParaReal(){
            return valorUsuario * cotacaoEuro;
        }

        public static float ConverterRealParaEuro(){
            return valorUsuario / cotacaoEuro;
        }
    }
}