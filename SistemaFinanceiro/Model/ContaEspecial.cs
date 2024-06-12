using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    internal class ContaEspecial : Conta
    {
        private double _limite = 1000;

        public ContaEspecial(long numero, Cliente titular) : base(numero, titular)
        {
        }

        public ContaEspecial(long numero, double saldo, Cliente titular) : base(numero, saldo, titular)
        {
        }
        public double Limite { get => _limite;
            private set
            {
                _limite = value;
            } }
        public override bool Saque(double valor)
        {
            if (Saldo + Limite - valor - 0.10 < 0)
            {
                throw new ArgumentException("Valor do saque é excedido.");
            } else 
            {
                Saldo -= valor + 0.10;
                return true;
            }
        }

        public override bool Transferencia(Conta destino, double valor)
        {
            if (Saque(valor))
            {
                destino.Deposito(valor);
                return true;
            }
            throw new ArgumentException("Transferencia não pôde ser realizada.");
        }
    }
}
}
