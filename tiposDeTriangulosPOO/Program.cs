namespace tiposDeTriangulosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do { 
            Console.Clear();

            Triangulo triangulo = new Triangulo();

            Console.Write("Digite o primeiro lado do Triângulo: ");
            triangulo.lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo lado do Triângulo: ");
            triangulo.lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro lado do Triângulo: ");
            triangulo.lado3 = Convert.ToInt32(Console.ReadLine());

            triangulo.tipo = triangulo.GerarTipo();
            Console.WriteLine(triangulo.tipo);

            Console.ReadLine();
            } while (true);
        }
    }
}