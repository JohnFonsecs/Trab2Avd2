using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(long numero, Cliente titular) : base(numero, titular)
        {
        }

        public ContaCaixinha(long numero, double saldo, Cliente titular) : base(numero, saldo, titular)
        {
        }

        public override void Deposito(double valor)
        {
            if (valor >= 1)
            {
                Saldo += valor + 1;
            }
            else
            {
                throw new ArgumentException("Valor do deposito deve ser superior a 1");
            }
        }

        public override bool Saque(double valor)
        {
            if (Saldo - valor - 5 >= 0)
            {
                Saldo = -valor + 5;
                return true;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassado");
            }
        }
    }
}
