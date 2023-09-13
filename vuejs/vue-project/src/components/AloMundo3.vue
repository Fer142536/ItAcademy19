<script setup lang="ts">
function tratadorDoClik(evento: Event){
 alert(`Alô, Mundo!`);
}

function tratadorDoClik2(evento:Event){
    const botaoClicado = evento.currentTarget as HTMLButtonElement;
    alert(`Oi,${botaoClicado.name}`)
}
</script>

<template>
    <button type="button" @click="tratadorDoClik">Diga Alô!</button>
    <button type="button" name="botaoOi" @click="tratadorDoClik2">Diga Oi!</button>

</template>