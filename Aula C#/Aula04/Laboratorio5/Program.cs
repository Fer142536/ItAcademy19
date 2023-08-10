namespace Laboratorio5;
using System.Drawing;

class Program{

 static void Main(string[] args){

Circulo circ1 = new Circulo();
Console.WriteLine(circ1);
Circulo circ2 = new Circulo(2.4, 5, 3);
Console.WriteLine(circ2);
CirculoColorido circ3 = new CirculoColorido();
Console.WriteLine(circ3);
CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
Console.WriteLine(circ4);

//Laboratório 5
CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido(3.2,5.0,1,"preto",Color.Blue);
Console.WriteLine(circ5); 
Console.WriteLine("\n");
}
}