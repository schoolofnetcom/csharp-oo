using System;

namespace POO
{
    public class ContaCorrente : Conta
    {
        private decimal taxaMovimento;

        public decimal TaxaMovimento
        {
            get { return taxaMovimento; }
            set { taxaMovimento = value; }
        }

        public ContaCorrente() : base(3000)
        {
            taxaMovimento = 0.1m;
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + (taxaMovimento * valor));
        }
        
        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
    }
}
