namespace Polimorfismo;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new("Fernanda",32);
        Console.WriteLine(p.ToString());

        p.anoDeNascimento = 1991;
        Console.WriteLine(p.ToString());

        Funcionario f = new(4000,"Fernanda",32);
        Console.WriteLine(f.ToString());

        //f = new(4000);
        //Console.WriteLine(f.ToString());

        Pessoa paux;
        paux = p;
        Console.WriteLine("//==================");
        Console.WriteLine("Pessoa");
        Console.WriteLine("Qual o seu humor?"+paux.humor());
        Console.WriteLine(paux);
        paux = f;
        Console.WriteLine("//==================");
        Console.WriteLine("Funcionário");
        Console.WriteLine(paux);
        Console.WriteLine("Qual o seu humor?"+paux.humor());
        Console.WriteLine("Paux é pessoa?"+(paux is Pessoa));
        Console.WriteLine("Paux é funcionário?"+(paux is Funcionario));
        if(paux is Funcionario)
        {
            //age como Funcionario
            Console.WriteLine("Esta satisfeito com o salario?"+(paux as Funcionario).satisfacaoSalarial());
        }

        object oaux;
        oaux = p;
        Console.WriteLine("//==================");
        Console.WriteLine("oPessoa");
        Console.WriteLine(oaux);
        //age como Pessoa
        Console.WriteLine("Qual o seu humor?"+((Pessoa)oaux).humor());
        oaux = f;
        Console.WriteLine("//==================");
        Console.WriteLine("oFuncionario");
        Console.WriteLine(oaux as object);
        Console.WriteLine(oaux as Pessoa);
        Console.WriteLine(oaux as Funcionario);
        Console.WriteLine("Qual o seu humor?"+((Pessoa)oaux).humor());
        Console.WriteLine("Qual o seu humor?"+((Funcionario)oaux).humor());
    }
}