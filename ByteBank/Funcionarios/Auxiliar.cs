using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }

        public string CPF { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Salario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
