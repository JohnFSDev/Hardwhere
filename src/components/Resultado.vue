<template>
  <v-container fluid class="fill-height d-flex align-center justify-center">
    <v-card  class="pa-5" style="width: 100%; max-width: 1000px">
      <v-row>
        <!-- Columna para la imagen -->
        <v-col cols="3">
          <v-card class="image-container">
            <v-img :src="components.urlImg" aspect-ratio="1"></v-img>
          </v-card>
        </v-col>

          <!-- Columna para el contenido -->
           <v-col cols="8" class="mt-2">
              <v-card-title class="custom-title">{{components.title}}</v-card-title>
                <template v-for="(value, key) in components" :key="key">
                  <v-card-text v-if="key !== 'title' && key !== 'description' && key !== 'urlImg'" class="text-left" style="font-size: 22px;">
                  {{ key }}: {{ value }}
                  </v-card-text>
                </template>
          </v-col>
      </v-row>
    </v-card>
    
  <v-divider/>

    <v-container>
      <v-row justify="center">
        <v-col cols="4" v-for="i in 3" :key="i">
          <v-card style="background-color: transparent;" elevation="0">
            <v-row no-gutters>
              <v-col cols="4">
                <v-sheet height="150">
                  <v-img  style="height: 100%; width: 100%; object-fit: contain" src="/computer-ram.jpg" aspect-ratio="1"></v-img>
                </v-sheet>
              </v-col>

              <v-col cols="8">
                <v-card-title class="customTitle">Ejemplo de Título 1</v-card-title>
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

  .customTitle {
    font-family: 'Zen Maru Gothic', sans-serif; 
    color: #023047;
  }

  .image-2nd {
    width: 150px;
    height: 150px;
  }

  .image-container {
  width: 100%;
  height: 100%;
  background-color: #fff; /* Fondo blanco para la imagen */
  border-radius: 12px;
  overflow: hidden;
  margin-right: 20px; /* Margen a la derecha para separar la imagen del texto */
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
    margin: 0; /* Asegura que no haya márgenes en el cuerpo de la página */
    padding: 0; /* Asegura que no haya relleno en el cuerpo de la página */
  }

</style>

<script>
  import axios from 'axios';

  export default {
    data: () => ({
      loaded: false,
      loading: false,
      components: {}
    }),

    created() {
      this.componentMethod();
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
      async componentMethod(){
        console.log(this.$route.params.components)
      await axios.get(`/api/Components/5`).then(response => {
        this.components = response.data;
        console.log(this.components);
      }).catch(error => {
        console.error(error);
      });
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
