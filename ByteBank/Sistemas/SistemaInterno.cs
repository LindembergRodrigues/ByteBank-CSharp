using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    internal class SistemaInterno
    {
        public bool Logar(Autenticavel autenticavel, String senha)
        {
            bool userAutenticador = autenticavel.Autenticar(senha);
            if (userAutenticador)
            {
                Console.WriteLine("<BEM VINDO AO SISTEMA DA BYTEBANK>");
                return true;
            }
            Console.WriteLine("Não autenticado!");
            return false;
        }
        


    }

}
