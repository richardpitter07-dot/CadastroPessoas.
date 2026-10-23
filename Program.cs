using System;

namespace CadastroPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Joao", 20, 101);
            Funcionario funcionario = new Funcionario("Maria", 30, 2500m);
            Gerente gerente = new Gerente("Carlos", 35, 4000m, "TI");

            Console.WriteLine("=== CLIENTE ===");
            cliente.Apresentar();
            Console.WriteLine("Codigo do cliente: " + cliente.CodigoCliente);

            Console.WriteLine();
            Console.WriteLine("=== FUNCIONARIO ===");
            funcionario.Apresentar();
            Console.WriteLine("Salario: R$ " + funcionario.Salario);
            Console.WriteLine("Bonus: R$ " + funcionario.CalcularBonus());

            Console.WriteLine();
            Console.WriteLine("=== GERENTE ===");
            gerente.Apresentar();
            Console.WriteLine("Salario: R$ " + gerente.Salario);
            Console.WriteLine("Departamento: " + gerente.Departamento);
            Console.WriteLine("Bonus: R$ " + gerente.CalcularBonus());

            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
