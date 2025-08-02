namespace ClaudeConsoleAppCalculadora.Models
{
    public static class Calculadora
    {
        private static double _operando1;
        private static double _operando2;

        public static double Somar(double numero1, double numero2)
        {
            _operando1 = numero1;
            _operando2 = numero2;
            return _operando1 + _operando2;
        }

        public static double Subtrair(double numero1, double numero2)
        {
            _operando1 = numero1;
            _operando2 = numero2;
            return _operando1 - _operando2;
        }

        public static double Multiplicar(double numero1, double numero2)
        {
            _operando1 = numero1;
            _operando2 = numero2;
            return _operando1 * _operando2;
        }

        public static double Dividir(double numero1, double numero2)
        {
            _operando1 = numero1;
            _operando2 = numero2;
            return _operando1 / _operando2;
        }
    }
}