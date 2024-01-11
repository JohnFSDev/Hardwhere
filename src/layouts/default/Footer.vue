<template>
    <v-footer @click = "ScrollToTop" style="background-color: #023047; position: fixed; bottom: 0; width: 100%; height: 6%; font-size: 20px;">
      <v-container class="d-flex justify-center text-white">
        Inicio de Pagina
      </v-container>

  </v-footer>
</template>

<script lang="ts">
import { defineComponent } from 'vue'

export default defineComponent({
    
    methods: {
        ScrollToTop() {
    // Obtener el elemento del cuerpo de la página
    const bodyElement = document.querySelector('body');

    // Desplazar suavemente hacia arriba
    bodyElement?.scrollIntoView({
      behavior: 'smooth',
      block: 'start', // Hacia el inicio del contenedor (parte superior)
      inline: 'nearest', // Alinea el inicio del contenedor con el borde más cercano del viewport
    });
  }
    }

})





</script>
