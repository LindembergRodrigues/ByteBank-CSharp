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
        public bool Logar(Funcionario diretor, String senha)
        {
            bool userAutenticador = diretor.Autenticar(senha);
            if (userAutenticador)
            {
                Console.WriteLine("<BEM VINDO AO SISTEMA DA BYTEBANK>");
                return true;
            }
            Console.WriteLine("Não autenticado!");
            return false;
        }
        public bool Logar(GerenteDeConta GConta, String senha)
        {
            bool userAutenticador = GConta.Autenticar(senha);
            if (userAutenticador)
            {
                Console.WriteLine(" BEM VINDO AO SISTEMA DA BYTEBANK ");
                return true;
            }
            return false;
        }


    }

}
