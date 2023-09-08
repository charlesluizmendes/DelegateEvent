namespace ConsoleApp.Classes
{
    public class Calculator
    {
        public delegate double Operation(double a, double b); // Criando o Delegate, return double, dois parametros de entrada
        public Operation operation; // Criando event, baseado no delegate acima

        public double RealizarOperacao(double x, double y)
        {
            return operation.Invoke(x, y); // Invocando o delegate event
        }
    }
}
