using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Conta
    {
        private long _numero;
        protected double _saldo;

        public Cliente Titular { get; set; }    
        public Conta(long numero, Cliente titular)
        {
            _numero = numero;
            Titular = titular;
            Saldo = 10;

        }

        public Conta(long numero, double saldo, Cliente titular) 
        {
            _numero = numero;
            _saldo = saldo;
            Titular = titular;
        }

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public double Saldo { get => _saldo;
            protected set
            {
                _saldo = value;
            }
        }

        // crie o código de teste para testar o método de depósito e saque da conta

        public virtual void Deposito(double valor)
        {
            Saldo += valor;
        }

        public virtual bool Saque(double valor)
        {
            if(Saldo - valor - 0.10 >= 0) 
            {
                Saldo -= valor + 0.10;
                return true;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }
            
        }
        public virtual bool Transferencia(Conta destino, double valor)
        {
            if (Saque(valor))
            {
               destino.Deposito(valor);
                return true;
            }
            return false;
        }
    }
}
