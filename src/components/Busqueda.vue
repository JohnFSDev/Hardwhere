<template>
    <v-toolbar>
    <v-app-bar color="#FFB703" :elevation="0">
      <img src="/hw_logo.png" height="270" />
      <v-card
      class="mx-auto"
      color="grey-lighten-3"
      max-width="700"
    >
      <v-card-text>
        <v-text-field
          :loading="loading"
          density="compact"
          variant="solo"
          label="Buscar"
          append-inner-icon="mdi-magnify"
          single-line
          hide-details
          style="width: 600px;"
          @click:append-inner="onClick"
        ></v-text-field>
      </v-card-text>
    </v-card>
    <a href="#">Que es Hardwhere</a>
    </v-app-bar>
  </v-toolbar>

<v-container>
  <v-card>
    <v-row no-gutters>
      <!-- Columna para el contenedor de la imagen -->
      <v-col cols="4">
        <v-card class="image-container">
          <v-img src="/computer-ram.jpg" aspect-ratio="1"></v-img>
        </v-card>
      </v-col>

      <!-- Columna para el contenido -->
      <v-col cols="8">
        <v-card-title class="custom-title bigger-font">Ejemplo de Título 2</v-card-title>
        <v-card-text>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque dictum facilisis dolor. Vestibulum vehicula dignissim libero, viverra convallis risus tempus nec...
        </v-card-text>
      </v-col>
    </v-row>
  </v-card>

  <!-- Divider entre cada resultado -->
  <v-divider class="my-7 custom-divider"></v-divider>  <!-- Resultado de búsqueda 2 -->
  <v-card>
    <v-row no-gutters>
      <!-- Columna para el contenedor de la imagen -->
      <v-col cols="4">
        <v-card class="image-container">
          <v-img src="/computer-ram.jpg" aspect-ratio="1"></v-img>
        </v-card>
      </v-col>

      <!-- Columna para el contenido -->
      <v-col cols="8">
        <v-card-title class="custom-title">Ejemplo de Título 2</v-card-title>
        <v-card-text>
          Descripción del segundo ejemplo de componente.
        </v-card-text>
      </v-col>
    </v-row>
  </v-card>
</v-container>
  
<v-footer style="background-color: #023047; position: fixed; bottom: 0; width: 100%;">
  <a href="#" onclick="scrollToTop()" style="text-decoration: none; color: white; display: block; text-align: center;">
    Inicio de la página
  </a>
</v-footer>

          

</template>


<style>

.bigger-font {
  font-size: 40px; /* Cambiar el tamaño de la fuente según sea necesario */
}

v-footer a {
  text-decoration: none; /* Quita el subrayado */
  color: white; /* Cambia el color del texto a blanco */
  display: block; /* Centra el texto */
  text-align: center; /* Centra el texto */
}

.image-container {
  width: 180px; /* Define el ancho del cuadro de imagen */
  height: 180px; /* Define la altura del cuadro de imagen */
  border-radius: 12px; /* Bordes curvos */
  overflow: hidden; /* Recorta el contenido que se desborda */
  margin-right: 20px; /* Espacio entre la imagen y el texto */
}

.rounded-image {
  border-radius: 12px; /* Bordes curvos para la imagen */
}

.custom-divider {
  border-top: 50px solid #219EBC; /* Grosor y color del divider */
}

.custom-title {
  color: #023047; /* Cambio de color del texto del título */
}

</style>

<script>
  export default {
    data: () => ({
      loaded: false,
      loading: false,
    }),

    methods: {
      onClick () {
        this.loading = true

        setTimeout(() => {
          this.loading = false
          this.loaded = true
        }, 2000)
      },
    },
  }

  function scrollToTop() {
    // Obtener el elemento del cuerpo de la página
    const bodyElement = document.querySelector('body');

    // Desplazar suavemente hacia arriba
    bodyElement.scrollIntoView({
      behavior: 'smooth',
      block: 'start', // Hacia el inicio del contenedor (parte superior)
      inline: 'nearest', // Alinea el inicio del contenedor con el borde más cercano del viewport
    });
  }
</script>