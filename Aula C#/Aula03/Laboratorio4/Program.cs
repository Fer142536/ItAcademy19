namespace Laboratorio4;

class Program
{
    static void Main(string[] args)
    {

    ContaCorrente minhaConta = new ContaCorrente(340);
    Console.WriteLine(minhaConta.Saldo);
    minhaConta.Depositar(100);
    Console.WriteLine(minhaConta.Saldo);

    minhaConta.Sacar(50);
    Console.WriteLine("Saldo após saque: " + minhaConta.Saldo);
    Console.WriteLine("Saldo Médio: " + minhaConta.SaldoMedio);



    ContaCorrente conta = new ContaCorrente("Fernanda");
    Console.WriteLine("Nome do Titular:"+conta.NomeTitular);
    Console.WriteLine("Data da criação:" +conta.DataCriacao);

    }
}
