<template>

    <v-container class="center-container">
      <v-card v-on:click="onClick(component.id)" elevation="1" v-for="component in components" :key="component.id" class="mb-4">

        <v-row>
          <!-- Columna para el contenedor de la imagen -->

            <v-card class="image-container">
              <v-img :src="component.urlImg" aspect-ratio="1"/>
            </v-card>

          <!-- Columna para el contenido -->
          <v-col cols="8">
            <v-card-title class="custom-title font-roboto">{{component.title}}</v-card-title>
            <v-card-text>
              {{component.description}}
            </v-card-text>
          </v-col>
        </v-row>
      </v-card>
      <!-- <v-pagination class="my-4" :length="15"></v-pagination> -->
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

  .center-container {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
}


</style>

<script>

  import axios from 'axios'
  // import searchBar from '@/layouts/default/Header.vue'
  export default {
    // data(){
    //   return {
    //     components : null
    //   }
    // },
    props: {
      components : {

      },
      
    },
    async mounted(){
      // console.log(this.searchInfo)
      // console.log(this.$route.params.component);
      const datosRuta = this.$route.params.component;
      console.log(datosRuta)
      // console.log("estoy en datos ruta  " + datosRuta)
      if(datosRuta != undefined){
        this.$emit('parametros-ruta', datosRuta);
      }
    },
    methods: {
      onClick (id) {
        this.$router.push(`/Components/${id}`);
        this.loading = true

        setTimeout(() => {
          this.loading = false
          this.loaded = true
        }, 2000)
      },
    }
  }
</script>
