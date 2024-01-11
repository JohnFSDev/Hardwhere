<template>

<v-container>

  <v-card elevation="0">
    <v-row no-gutters>
      <!-- Columna para el contenedor de la imagen -->
      <v-col cols="4">
        <v-card class="image-container">
          <v-img src="/computer-ram.jpg" aspect-ratio="1"></v-img>
        </v-card>
      </v-col>

      <!-- Columna para el contenido -->
      <v-col cols="8">
        <v-card-title class="custom-title">{{component.title}}</v-card-title>
        <v-card-text>
          {{component.description}}
        </v-card-text>
        <v-card-text>
          Marca
        </v-card-text>

        <v-card-text>
          Ejemplo 1
        </v-card-text>

        <v-card-text>
          Ejemplo 2
        </v-card-text>
      </v-col>
    </v-row>
  </v-card>

</v-container>


<v-container>

  <v-divider class="my-7"></v-divider>

  <!-- <v-row justify="center">
    <v-col cols="4" v-for="i in 3" :key="i">
      <v-card class="image-2nd">
        <v-row no-gutters>
          <v-col cols="4">
            <v-card class="image-2nd">
              <v-img src="/computer-ram.jpg" aspect-ratio="1"></v-img>
            </v-card>
          </v-col>

          <v-col cols="8">
            <v-card-title class="custom-title" style="color: black;">Ejemplo de Título 1</v-card-title>
            <v-card-text>
              Descripción del primer ejemplo de componente.
            </v-card-text>
          </v-col>
        </v-row>
      </v-card>
    </v-col>
  </v-row> -->
</v-container>


</template>

<style>

@import url('https://fonts.googleapis.com/css2?family=Zen+Maru+Gothic:wght@700&display=swap');

  .custom-title {
    color: #023047;
    font-family: 'Zen Maru Gothic', sans-serif;
    font-size: 40px;
  }

.image-2nd {
  width: 150px;
  height: 150px;
}

.image-container {
  width: 350px; /* Define el ancho del cuadro de imagen */
  height: 350px; /* Define la altura del cuadro de imagen */
  border-radius: 12px; /* Bordes curvos */
  overflow: hidden; /* Recorta el contenido que se desborda */
}

.rounded-image {
  border-radius: 12px; /* Bordes curvos para la imagen */
}

</style>

<script>
  import axios from 'axios';

  export default {
    data: () => ({
      loaded: false,
      loading: false,
      components: null,
    }),

    async mounted() {
      await axios.get(`/api/${this.$route.params.component}`).then(response => {
        this.components = response.data;
        console.log(response.data);
      }).catch(error => {
        console.error(error);
      });

      this.loading = true;
      setTimeout(() => {
        this.loading = false;
        this.loaded = true;
      }, 2000);

      this.$nextTick(() => {
        this.scrollToTop();
      });
    },

    methods: {
      onClick() {
        this.loading = true;

        setTimeout(() => {
          this.loading = false;
          this.loaded = true;
        }, 2000);
      },

      scrollToTop() {
        const bodyElement = document.querySelector('body');

        bodyElement.scrollIntoView({
          behavior: 'smooth',
          block: 'start',
          inline: 'nearest',
        });
      },
    },
  }
</script>
