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
      <v-pagination v-model="currentPage" class="my-4" :length="totalResults"></v-pagination>
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
  export default {
    data(){
      return {
        components : null,
        currentPage: 1, //Inicializa en 1, varia dependiendo de lo que clicke el usuario.
        totalResults: 3
      }
    },
    watch: {
    currentPage() {
      
    // this.SpecificComponent();
    this.searchComponent();

    },
  },

    created(){

        this.searchComponent();

      // console.log(this.searchInfo)

      // const datosRuta = this.$route.params.component;
      // console.log(datosRuta)
      // console.log("estoy en datos ruta  " + datosRuta)
      // if(datosRuta != undefined){
      //   this.$emit('parametros-ruta', datosRuta);
      // }
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
      searchComponent(){
        if(this.$route.params.search){
          axios.get(`/api/Components/Search?searchText=${this.$route.params.search}&pageResults=${this.totalResults}&page=${this.currentPage}`).then(response => {
        this.components = response.data;
        console.log(response.data);
      }).catch(error => {
        console.error(error);
      });
        }
        axios.get(`/api/${this.$route.params.component}`).then(response => {
        this.components = response.data
        console.log(response.data);
        }).catch(error => {
        console.error(error);
        });

              // console.log(this.$route.params.search);
        // console.log(this.totalPages)
        // console.log(this.currentPage)
      },
      SpecificComponent(){

      }
    }
  }
</script>
