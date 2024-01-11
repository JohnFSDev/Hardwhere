<template>
  <v-container>
    <v-card elevation="0" v-for="(item, index) in data" :key="index" class="mb-4">
      <v-row no-gutters>
        <!-- Columna para el contenedor de la imagen -->
        <v-col cols="4">
          <v-card class="image-container">
            <v-img :src="item.imagen" aspect-ratio="1"></v-img>
          </v-card>
        </v-col>

        <!-- Columna para el contenido -->
        <v-col cols="8">
          <v-card-title class="custom-title">{{ item.titulo }}</v-card-title>
          <v-card-text>{{ item.descripcion }}</v-card-text>
        </v-col>
      </v-row>
      <!-- Divider entre las tarjetas -->
      <v-divider class="my-7 custom-divider"></v-divider>
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

  .custom-divider {
    border-top: 50px solid #219EBC; /* Grosor y color del divider */
  }

  .custom-title {
    color: #023047; /* Cambio de color del texto del título */
    font-family: 'Roboto', sans-serif; /* Aplicar la fuente Roboto */
  }

</style>

<script>
import jsonData from '/src/assets/data.json';
export default {
  data() {
    return {
      data: [],
      loaded: false,
      loading: false
    };
  },
  mounted() {
    this.data = jsonData;
    console.log('Datos del archivo JSON:', this.data);
  },
  methods: {
    onClick() {
      this.loading = true;

      setTimeout(() => {
        this.loading = false;
        this.loaded = true;
      }, 2000);
    }
  }
};
</script>
