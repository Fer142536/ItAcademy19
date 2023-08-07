namespace _02_Classes;
class Program
{
    static void Main(string[] args)
    {
        string first = "xuxu";
        string second = string.Empty;
        int third = 3;
        DateTime? data = null;

        Console.WriteLine("O valor de first é:" + first);
        Console.WriteLine("O valor de second é:"+ second);
        Console.WriteLine("O valor de third é:"+ third);
        Console.WriteLine("O valor de data é:"+ data);

        DateTime? d1 = null;
        DateTime? d2 = null;
        DateTime? d3 = null;

         Console.WriteLine("Valores das variaveis é:");
        Console.WriteLine("O valor de d1 é:"+ d1);
        Console.WriteLine("O valor de d2 é:"+ d2);
        Console.WriteLine("O valor de d3 é:"+ d3);

        Cliente c = new Cliente();
        Console.WriteLine(c);
        //Console.WriteLine(c.tipo);

        //acessando um método publico da classe Cliente
        c.Saudacao();
        //Cliente.saudacao(); -> Causou um erro de compilação

        Console.WriteLine("O limite de crédito é: "+ c.consultaLimite());
        Console.WriteLine("Adicionando R$ 50,00 de limite: ");
        c.AumentarLimite(50M);
        Console.WriteLine("O limite de crédito é: "+ c.consultaLimite());

        //Explorando paramtros com metodo out
        int a = 10;
        int b;

        /*Não funciona pois sem o out, a variavel sem valor pré definido não é aceita na passagem de parametro
        Console.WriteLine("O valor de a é: "+ a);
        c.MetodoNormal(a,b);
        Console.WriteLine("Depois da chamada com o out:");
        Console.WriteLine("O valor de a é: "+ a);
        Console.WriteLine("O valor de b é: "+ b);
        */
        
        Console.WriteLine("O valor de a é: "+ a);
        c.MetodoOut1(a,out b);
        Console.WriteLine("Depois da chamada com o out:");
        Console.WriteLine("O valor de a é: "+ a);
        Console.WriteLine("O valor de b é: "+ b);

        Console.WriteLine("\nAntes da chamada do método com ref:");
        Console.WriteLine("O valor de a é: "+ a);
        c.MetodoRef1(a,ref b);
        Console.WriteLine("Depois da chamada com o ref:");
        Console.WriteLine("O valor de a é: "+ a);
        Console.WriteLine("O valor de b é: "+ b);

        Console.WriteLine("\nMétodo com nro dinâmico de parâmetros:");
        int[] minhaLista = new int[4]{1,2,3,4};
        c.MetodoParam(minhaLista);

        //manipulação de propriedade
        Console.WriteLine("\nNome do cliente é: "+c.Nome);
        c.Nome = "Milena Petersen";
        Console.WriteLine("Nome do cliente é: "+c.Nome);
    }

    }

