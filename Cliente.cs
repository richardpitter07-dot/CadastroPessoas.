namespace CadastroPessoas
{
    public class Cliente : Pessoa
    {
        public int CodigoCliente { get; set; }

        public Cliente(string nome, int idade, int codigoCliente)
            : base(nome, idade)
        {
            CodigoCliente = codigoCliente;
        }
    }
}
