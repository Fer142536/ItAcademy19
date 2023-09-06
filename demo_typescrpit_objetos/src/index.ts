import { Console } from "console";

const pessoa = {
    nome : 'Fernanda',
    idade: 33
};
console.log(pessoa.nome);
console.log(pessoa.idade);

// alterar idade 
pessoa.idade= 25
console.log(pessoa.idade);

// certerza que criou um objeto
console.log(typeof pessoa);

// criando pessoas 
const outraPessoa = {
    nome: 'Zoe',
    idade: 3,
    //a seta quer dizer uma função
    //saudar: () =>  'Olá!'
    saudar: function () 
{ `Olá! Meu nome é: {this.nome}`
}
};
console.log(outraPessoa.idade);
console.log(outraPessoa.saudar);

//o mesmo exemplo só que de sintaxe enxuta
const maisUmaPessoa = {
    nome: 'Théo',
    idade: 3,
    saudar () {
        return  `Olá! Meu nome é: {this.nome}`;
    }
};
console.log(maisUmaPessoa.saudar());

//para fazer isso funcionar precisa ter as mesmas propriedades em todas as pessoas criadas 
//como ex. nome e idade
function alo (umaPessoa: {nome:string; idade:number})
{
    console.log(`Alo, ${umaPessoa.nome}! Você tem ${umaPessoa.idade} anos!`);
}
alo(pessoa);
alo (outraPessoa);
alo (maisUmaPessoa);

//objeto com get 
const temperatura ={
 celsius : 23,
 get fahrenheit (){
    return this.celsius * 1.8 +32;
}
};
console.log(temperatura.celsius);
console.log(temperatura.fahrenheit);
console.log(`A temperatura é: ${temperatura.fahrenheit}`);

//criar o mesmo objeto com o mesmo type 
const outraTemperatura = Object.create(temperatura);
console.log(outraTemperatura.celsius);

//construtor de objetos
type Carro = {modelo:string, fabricante:string, ano:number}
function Carro (this:Carro, modelo:string, fabricante:string, ano:number){
    this.modelo = modelo;
    this.fabricante = fabricante;
    this.ano= ano;

    }
    const carro = new (Carro as any) ('fusca', 'VW', 1970);
    console.log(carro);
