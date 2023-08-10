namespace Laboratorio6;

class ContaPoupanca : Conta
{
    
private decimal taxaJuros;
private DateTime dataAniversario;

// Construtor
public ContaPoupanca(decimal j, DateTime d, string t): base(t)
{
taxaJuros = j;
dataAniversario = d;
}

// Propriedades
public decimal Juros
{
 get { return taxaJuros; }
 set { taxaJuros = value; }
}
public DateTime DataAniversario
{
 get { return dataAniversario; }
}

// Método que adiciona o rendimento da conta
public void AdicionarRendimento()
{
DateTime hoje = DateTime.Now;
if (hoje.Day == dataAniversario.Day && hoje.Month == dataAniversario.Month)
{
 decimal rendimento = this.Saldo * taxaJuros;
 this.Depositar(rendimento);
}
}

// Implementar a propriedade abstrata herdada da classe base:
public override string Id
{
get { return this.Titular + "(CP)"; }
}

}