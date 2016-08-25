using System;

namespace POO
{
    class MinhaExcecao : Exception
    {
        public Exception MensagemErro(string msg)
        {
            return new Exception(msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 2;

                if (b == 0)
                    throw new MinhaExcecao().MensagemErro("Uma mensagem qualquer de excecao");

                int resultado = a / b;
                Console.WriteLine(resultado);

                int[] vetor = new int[] { 1, 2, 3 };
                Console.WriteLine(vetor[0]);
            }
            //catch (MinhaExcecao ex)
            //{
            //    Console.WriteLine(ex.MensagemErro);
            //}
            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("Erro: Divisão por zero!!!");
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine("Erro: Fora do indice da colecao!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fim da execução.");
            }

            Console.Read();

            //Conta c = new Conta();
            //ContaCorrente cc = new ContaCorrente();
            //ContaPoupanca cp = new ContaPoupanca();

            //cc.Depositar(1000);
            //cp.Depositar(1000);

            //cc.Sacar(200);
            //cp.Sacar(200);

            //Console.WriteLine(cc.Saldo);
            //Console.WriteLine(cp.Saldo);

            //Relatorio rel = new Relatorio();
            //rel.Somar(cc);
            //rel.Somar(cp);

            //rel.SomarTributos(cp);

            //Console.WriteLine(rel.SaldoGeral);
            //Console.WriteLine(rel.TributoGeral);

            //Console.Read();
        }
    }
}
