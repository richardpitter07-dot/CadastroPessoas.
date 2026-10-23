namespace CadastroPessoas
{
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }

        public Funcionario(string nome, int idade, decimal salario)
            : base(nome, idade)
        {
            Salario = salario;
        }

        public decimal CalcularBonus()
        {
            return Salario * 0.10m;
        }
    }
}
