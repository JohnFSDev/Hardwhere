<template>
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
        <v-card-title class="custom-title">Ejemplo de Título 1</v-card-title>
        <v-card-text>
          Descripción del primer ejemplo de componente.
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

</template>


<style>

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
</script>