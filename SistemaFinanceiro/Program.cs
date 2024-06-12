// See https://aka.ms/new-console-template for more information
using SistemaFinanceiro.Model;

try
{
    var cliente1 = new Cliente("José", "12345678901");
    var conta1 = new Conta(123, 500, cliente1);
    Console.WriteLine("A conta {0} pertence a {1}", conta1.Numero, cliente1.Nome);

    ////deposito
    //conta1.Deposito(500);
    //Console.WriteLine("Saldo da conta {0} é: {1}", conta1.Numero,conta1.Saldo);
    //// transferencia
    //var cliente2 = new Cliente("Jonas","44455566677");
    //var conta2 = new Conta(521, 1500.10, cliente2);
    //conta2.Transferencia(conta1, 1000);
    //Console.WriteLine("Saldo da conta 1: {0}", conta1.Saldo);
    //Console.WriteLine("Saldo da conta 2: {0}", conta2.Saldo);

    //var contaE1 = new ContaEspecial (990, cliente1);
    //Console.WriteLine(contaE1.Limite);


} catch (Exception e)
{
    Console.WriteLine(e.Message);
}
