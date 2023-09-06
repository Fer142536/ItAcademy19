//Array

import { FORMERR } from "dns";

const numeros= [1,2,3,4,5];
console.log(numeros);
console.log(numeros[0]);
numeros[0]= 0;
console.log(numeros);
console.log(numeros.length);
numeros.length =10;
console.log(numeros.length);

console.log(numeros);
console.log(numeros[7]);

console.log('Imprimir conteudo array');
for (let i =0; i<numeros.length; i++){
    console.log(numeros[i]);
}

console.log('Imprimir conteudo array');
for (let n of numeros){
    console.log(n);
}

console.log('Imprimir conteudo array');
numeros.forEach(n => console.log(n));

console.log('Imprimir conteudo array');
numeros.forEach((n,i) => console.log(`numeros[${i}] =${n}`));

// find é verdadeiro ou falso
const palavras =[ 'alfa', 'bravo', 'charlie','delta'];
const resultado = palavras.find(p => p.length === 5);
console.log(resultado);

//filtrar
const resultado2 = palavras.filter(p => p.length > 4);
console.log(resultado2);

//map retorna p/ cada palavra do array e o tamanho dela 
const resultado3 = palavras.map(p => p.length);
console.log(resultado3);

//reduce- somar todos os elementos do array
const resultado4 = numeros.reduce((valorAnterior, valorAtual) => valorAnterior+valorAtual, 0);
console.log(resultado4);

// const ordenado = numeros.toSorted(); // ES2023 = não disponível pq setamos a 2022

//MAPAS
const mapa = new Map<string, string>();
mapa.set('RS', 'Rio Grande do Sul');
mapa.set('SC', 'Santa Catarina');
mapa.set('PR', 'Paraná');
console.log(mapa.get('RS'));

for(let e of mapa) {
    console.log(e);

}

for(let sigla of mapa.keys()) {
    console.log(sigla);

}

for(let estado of mapa.values()) {
    console.log(estado);

}

const conjunto = new Set<number>();
conjunto.add(1);
conjunto.add(2);
conjunto.add(1);
console.log(conjunto.size);


