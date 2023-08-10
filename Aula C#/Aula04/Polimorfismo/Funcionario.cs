namespace Polimorfismo;
public class Funcionario : Pessoa
{
    public decimal salario{get;}
    private const decimal SALARIO_MINIMO = 1300.25m;

    public Funcionario(decimal salario, string nome, int idade) : base(nome, idade)
    {
        this.salario = salario;
    }

    public Funcionario(decimal salario) : this(salario,"João Ninguem", -1){}

    public string satisfacaoSalarial()
    {
        Random r = new();
        if(r.Next()%10<3){
            return "insatisfeito";
        }
        else
        {
            return "satisfeito";
        }
    }

    public override string? ToString()
    {
        return base.ToString()+"Salário: R"+this.salario.ToString("C");
    }
}