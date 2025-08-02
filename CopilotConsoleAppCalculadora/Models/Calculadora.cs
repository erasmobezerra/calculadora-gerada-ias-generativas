namespace CopilotConsoleAppCalculadora.Models
{
    public static class Calculadora
    {
        private static double _numero1;
        private static double _numero2;

        public static double Dividir(double numero1, double numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;

            if (_numero2 == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");

            return _numero1 / _numero2;
        }

        public static double Multiplicar(double numero1, double numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;
            return _numero1 * _numero2;
        }

        public static double Somar(double numero1, double numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;
            return _numero1 + _numero2;
        }

        public static double Subtrair(double numero1, double numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;
            return _numero1 - _numero2;
        }
    }
}