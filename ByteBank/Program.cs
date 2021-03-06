using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao(); 
            SistemaInterno sistemasInterno = new SistemaInterno();

            Diretor diretor = new Diretor("123456789-09");
            diretor.Senha = "12345";
            Console.WriteLine("okok" == "okok");
            GerenteDeConta GConta = new GerenteDeConta("14785236989");
            GConta.Senha = "7548";

            Console.WriteLine("\nDIRETOR");
            
            sistemasInterno.Logar(diretor, "1524"); 
            sistemasInterno.Logar(diretor,diretor.Senha);


            Console.WriteLine("\nGERENTE COMERCIAL");

            sistemasInterno.Logar(GConta, "1524");
            sistemasInterno.Logar(GConta, GConta.Senha);


            ParceiroComercial PComercial = new ParceiroComercial();
            PComercial.Senha = "26538";

            Console.WriteLine("\nPARCEIRO COMERCIAL");

            sistemasInterno.Logar(PComercial, "26538");
            sistemasInterno.Logar(PComercial, "265385");

            Console.ReadLine();
        }

        public static void CalcularBonificacao() 
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20"); 
            guilherme.Nome = "Guilherme"; 

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}