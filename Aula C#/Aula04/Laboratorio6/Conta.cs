namespace Laboratorio6;

public abstract class Conta{

private decimal saldo;
private string titular;


// Construtor
public Conta(string t)
{
titular = t;
}

// Propiedades de Leitura
public decimal Saldo
{
get { return saldo; }
}
public string Titular
{
get { return titular; }
}

//Definindo métodos/propriedades abstratos
public abstract string Id
{
get;
}

//Definindo métodos/propriedades passíveis de sobrescrita
public virtual void Depositar(decimal valor)
{
saldo += valor;
}
//
public virtual void Sacar(decimal valor)
{
saldo -= valor;
}

}