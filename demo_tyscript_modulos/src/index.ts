// importar módulos
 import {area, circunferencia as cir} from './circulo_funcoes';
import circ from './circulo_objetos';
import * as fs from 'node:fs';
import { json } from 'stream/consumers';
import Circulo from './circulo_objetos';

// usando as funções 
console.log(area(3.75));
console.log(cir(4));

//usando classe importada
const c1 = new circ(10.5);
console.log(c1.area());
console.log(c1.circunferencia());

//Gravando um arquivo de texto 
/*const json = JSON.stringify(c1);
try {
    fs.writeFileSync('dados.json', json);
} catch (error) {
    console.error('Falha na escrita do arquivo');
    console.error((error as Error).message);
    //console.error(error);
}*/

//Leitura do arquivo de texto
try {
const json = fs.readFileSync('dados.json', {encoding:'utf-8'});
const circulo = JSON.parse(json);
console.log(circulo.circunferencia());
} catch (error) {
console.log('Falha na leitura do arquivo');
console.error((error as Error).message);
}


