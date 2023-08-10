using System;

class ContaCorrente {

 private decimal saldo, saldoMedio;   
 private string nomeTitular;
 private DateTime dataCriacao;
 private int contador;
 

//construtor
public ContaCorrente(decimal saldo, string nomeTitular) {
        this.saldo = saldo;
        dataCriacao = DateTime.Now;
        this.nomeTitular = nomeTitular;
       
}


 // get

 public DateTime DataCriacao {
        get { return dataCriacao; }
    }

    public string NomeTitular {
        get { return nomeTitular; }
    }
    public decimal SaldoMedio
    {   
        get { return saldoMedio / contador; }
    }



 //atribuindo saldo para a conta

 //depositando
 public void Depositar(decimal val)
{
saldo = saldo + val;
apuraSaldoMedio();
}


// sacando valor
public void Sacar(decimal val)
{
saldo = saldo - val;
apuraSaldoMedio();

}

//retornando saldo
public decimal Saldo
{
get { return saldo; }
}

private void apuraSaldoMedio(){
        contador++;
        saldoMedio += saldo;
    }

//Definindo um método construtor para inicializar os atributos de uma classe
public ContaCorrente(decimal val)
{
saldo = val;
}

public ContaCorrente(string  n)
{
nomeTitular = n;
}

public void AdicionaNome(string n)
{
nomeTitular = n;
}
}