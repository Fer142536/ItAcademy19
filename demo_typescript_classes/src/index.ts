//classe com propriedades publicas 
class Pessoa{
nome: string;
idade: number;

constructor (nome: string, idade:number){
    this.nome =nome;
    this.idade =idade;

}
}
const p1 = new Pessoa ('Fernanda', 33);
const p2 = new Pessoa ('Zoe', 3);
console.log(typeof p1);
console.log(typeof p2);
console.log(p1);
console.log(p2);

//classe com propriedades públicas - sixtaxe enxuta
class PessoaV2{
    constructor (public nome: string, public idade:number){
}
}
const p3 = new PessoaV2 ('Tales', 41);
console.log(p3);

//classe com propriedades privadas
class PessoaV3{
    #nome : string;
    #idade: number;
    #peso = 0;

constructor (nome: string, idade:number){
    this.#nome = nome;
    this.#idade= idade;
}
get nome(){
    return this.#nome;
}
get idade(){
    return this.#idade;
}
get peso(){
    return this.#peso;
}
set peso(novoPeso: number){
    this.#peso = novoPeso;
}
fazAniversario(){
    this.#idade = this.#idade +1;
}
}
const p4 = new PessoaV3 ('Athena', 3);
console.log(p4.nome);
console.log(p4.idade);
p4.peso = 5;
console.log(p4.peso);
p4.fazAniversario();
console.log(p4.idade);

let{nome,idade} = p4;
console.log(nome);

function saudar({nome}:Pessoa){
    console.log(`Alô,${nome}!`); 
}
saudar(p4);

//gerar JSON
const json= JSON.stringify(p1);
console.log(json);
// ler JSON
const json2= '{"nome": "Json da Silva", "idade": 8}';
const obj2: Pessoa = JSON.parse (json2);
console.log(obj2);








