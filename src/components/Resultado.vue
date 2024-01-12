
<template>
  <v-container fluid class="fill-height d-flex" style="background-color: #f4f4f6;">
    <v-container>
      <v-card elevation="0" style="background-color: #f4f4f6;">
        <v-row align="center">
          <!-- Columna para el contenedor de la imagen -->
          <v-col cols="4">
            <v-card class="image-container">
              <v-img src="/computer-ram.jpg" aspect-ratio="1"></v-img>
            </v-card>
          </v-col>

          <!-- Columna para el contenido -->
          <v-col cols="8" class="mt-2">
            <v-card-title class="custom-title">ASUS Dual Geforce RTX 4060</v-card-title>
            <v-card-text class="limited-width">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque dictum facilisis dolor. Vestibulum vehicula dignissim libero, viverra convallis risus tempus nec. Nullam aliquet odio vel risus rhoncus, a convallis leo sollicitudin. Sed eu purus neque. Sed ultricies ligula ut 
            </v-card-text>
            <v-card-text style="font-size: 22px;">
              Marca: ASUS
            </v-card-text>
          
            <v-card-text style="font-size: 22px;">
              Graphic Coprocessor: Nvidia Geforce 4060
            </v-card-text>
          
            <v-card-text style="font-size: 22px;">
              Graphics Ram: 2500mhz
            </v-card-text>
          </v-col>
        </v-row>
      </v-card>
    </v-container>

    <v-container>
      <v-divider class="my-7"></v-divider>

      <v-row justify="center">
        <v-col cols="4" v-for="i in 3" :key="i">
          <v-card class="image-2nd">
            <v-row no-gutters>
              <v-col cols="4">
                <v-card class="image-2nd">
                  <v-img src="/computer-ram.jpg" aspect-ratio="1"></v-img>
                </v-card>
              </v-col>

              <v-col cols="8">
                <v-card-title style="color: black;">Ejemplo de Título 1</v-card-title>
                <v-card-text>
                  Descripción del primer ejemplo de componente.
                </v-card-text>
              </v-col>
            </v-row>
          </v-card>
        </v-col>
      </v-row>
    </v-container>
  </v-container>
</template>

<style>
  @import url('https://fonts.googleapis.com/css2?family=Zen+Maru+Gothic:wght@700&display=swap');

  .custom-title {
    font-size: 30px !important;
    color: #023047;
    font-family: 'Zen Maru Gothic', sans-serif; 
  }

  .image-2nd {
    width: 150px;
    height: 150px;
  }

  .image-container {
    width: 400px;
    height: 400px;
    border-radius: 12px;
    overflow: hidden;
  }

  .rounded-image {
    border-radius: 12px;
  }

  .limited-width {
    max-width: 650px;
    font-size: 20px !important;
    margin-top: 20px;
  }

  body {
    background-color: #f4f4f6;
    margin: 0;
    padding: 0;
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
