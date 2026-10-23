namespace CadastroPessoas
{
    public class Gerente : Funcionario
    {
        public string Departamento { get; set; }

        public Gerente(string nome, int idade, decimal salario, string departamento)
            : base(nome, idade, salario)
        {
            Departamento = departamento;
        }
    }
}
