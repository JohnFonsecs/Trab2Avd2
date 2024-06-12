using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Cliente {
        public string Email { get; set; }
        public int anoNascimento { get; set; }
        public string Nome { get; set; }
        public string cpf { get; set; }

        public Cliente(string nome, string cpf)
        {
            if (cpf.Length != 11)
            {
                throw new System.ArgumentException("O cpf precisa ter 11 digitos.");
            }
            Nome = nome;
            this.cpf = cpf;
        }
    }

}
