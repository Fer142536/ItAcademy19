namespace Polimorfismo;
public class Pessoa
{
    public string nome;
    public int idade{get; private set;}
    public int anoDeNascimento{
        get
        {
            DateTime hoje = DateTime.Now;
            return hoje.Year-idade;
        }
        set
        {
            this.idade = DateTime.Now.Year - value;
        }
    }

    //public Pessoa() : this("João Ninguém", -1){}

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public string humor()
    {
        Random r = new Random();
        switch (r.Next(3))
        {
            case 0: return "alegre";
            case 1: return "feliz";
            case 2: return "contente";
            default: return "apático";
        }
    }

    public override string? ToString()
    {
        string texto = "/===================\n";
        texto += $"Nome: {this.nome} \n";
        texto += $"Idade: {this.idade} \n";
        texto += $"Ano de Nascimento: {this.anoDeNascimento} \n";
        return texto;
    }

}