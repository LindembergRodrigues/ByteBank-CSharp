using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        
        public String Senha { get; set; }

        public Autenticavel(double salario, String cpf) : base(salario, cpf)
        {

        }
        public bool Autenticar(String senha)
        {
            return Senha == senha;
        }
    }
}


