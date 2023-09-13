<script setup lang="ts">
const nome = 'Fernanda Souza';
</script>

<template>
    <h2>Alô, {{ nome }}!</h2>
   <p>
    São <time :datatime="Date()">{{ new Date().toLocaleTimeString() }}</time> horas.
</p>
 
</template>