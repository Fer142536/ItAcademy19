let saudacao: string ="Hello Mundo";
console.log(saudacao);

function saudar () {
    console.log("Alô Mundo!");
}
saudar();

// USAR CRASE QUANDO TER $
function saudarComNome(nome: string){
    console.log(`Alô, ${nome}!`);
}
saudarComNome("Fernanda");

function criarSaudacao(nome: string){
    return `Alô, ${nome}!`;
}
console.log(criarSaudacao("Fernanda"));

function potencia(base: number, expoente: number){
    let resultado = 1;
    for(let cont =0 ; cont <expoente; cont++){
    resultado = resultado *base;
}
return resultado;
}
console.log(potencia(2,3));

// funçoes anonimas 
const saudarAnonima = function (nome:string) {
    return `Alô, ${nome}!`
    
}
console.log(saudarAnonima);
console.log(saudarAnonima("Fernanda"));

//funções arrow
const saudarArrow = (nome :string) => `Alô, ${nome}!`
console.log(saudarArrow("Fernanda"));

// execução imediata de uma função
(function (x: number, y:number){
console.log(x +y); 

}) (1,2);

//closure 
function multiplicar(fator: number): (n:number) => number{
    return numero => numero * fator;
}
const dobrar = multiplicar(2);
console.log(dobrar(5));