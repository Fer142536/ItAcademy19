//questão 1
function imprimirPares(inicio: number, fim: number): void {
    for (let i = inicio; i <= fim; i++) {
      if (i % 2 === 0) {
        console.log(i);
      }
    }
  }
  imprimirPares(1, 10);

  //questão 2 
/*let i: number = 0;
while (i != 10) {
 i += 0.2;
}*/

//questão 3
function min(x: number, y: number): number {
    if (x < y) {
      return x;
    } else {
      return y;
    }
}
const menorNumber = min(1, 10);
console.log(`O numero menor é: ${menorNumber}`);

// questões 5
function toMaiusculaPrimeira(s: string ): string{
// retorna caracter
return s.charAt (0).toUpperCase() +s.substring(1,s.length);
}
const letraMaiusc = toMaiusculaPrimeira('fernanda'); 
console.log(`A letra maiuscula é: ${letraMaiusc}`);


//questão 4
function pow(x: number, y: number): number {
  if (y=== 0){
    return 1;
  }
  let resultado = 1;
for (let i = 0; i <= y; i++) {
    resultado *= x;
  }
return resultado;
}

// Exemplo de uso:
const base = 2;
const expoente = 3;

console.log(`Resultado: ${base}^${expoente} = ${pow(base, expoente)}`);
  
  

  
  

