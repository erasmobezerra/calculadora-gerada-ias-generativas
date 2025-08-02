namespace GeminiConsoleAppCalculadora.Models
{
    public static class Calculadora
    {
        // Propriedades privadas para armazenar os operandos (embora não estritamente necessárias para métodos estáticos puros)
        // private static double _operando1;
        // private static double _operando2;

        public static double Dividir(double num1, double num2)
        {
            // _operando1 = num1;
            // _operando2 = num2;
            if (num2 == 0)
            {
                throw new DivideByZeroException("Erro: Não é possível dividir por zero.");
            }
            return num1 / num2;
        }

        public static double Multiplicar(double num1, double num2)
        {
            // _operando1 = num1;
            // _operando2 = num2;
            return num1 * num2;
        }

        public static double Somar(double num1, double num2)
        {
            // _operando1 = num1;
            // _operando2 = num2;
            return num1 + num2;
        }

        public static double Subtrair(double num1, double num2)
        {
            // _operando1 = num1;
            // _operando2 = num2;
            return num1 - num2;
        }
    }
}