using System;
namespace LaboratorioArrays;

class Program
{
    static void Main(string[] args)
    {

    // Arrays tamanho igual
        int[] arrayUm = new int[100];                         
        int[] arrayDois = new int[100]; 

    //Popular Array
        for (int i = 0; i < 100; i++)
            {
                arrayUm[i] = i + 1;
            }
    //Copiar arrays
    Array.Copy (arrayUm,arrayDois,100);

    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine("Indice = " + i + " & Valor = " + arrayDois[i]);
    }




        int[] array = new int[5] { 10, 20, 30, 40, 50 };
       // int i = 0;
        foreach (int valor in array)
        {
        Console.WriteLine("Indice = " +  + valor);
        
        }

    string[] str = new string[3];
    int iStr= 0;
    str[0] = "Um";
    str[1] = "Dois";
    str[2] = "Tres";
    foreach (string valor in str)
    {
    Console.WriteLine("Indice = " + iStr + " & Valor = " + valor);
    iStr++;
    }

    DateTime[] dt = new DateTime[2];
    int iDate = 0;
    dt[0] = new DateTime(2002, 5, 1);
    dt[1] = new DateTime(2002, 6, 1);

    foreach (DateTime valor in dt)
    {
    Console.WriteLine("Indice = " + iDate + " & Valor = " + valor);
    iDate++;
    }
    

    }
}
