using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Funcionario, Autenticavel
    {
        
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public string Senha { get; set ; }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        
    }
}
