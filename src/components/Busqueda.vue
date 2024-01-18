<template>

<v-container class="d-flex justify-center">
<div style="width: 100%; max-width: 700px" >
  <v-card class="mb-5" v-on:click="onClick(component.id)" elevation="3" v-for="component in components" :key="component.id">
        <v-row>
          <!-- Contenedor de la imagen -->
          <v-col cols="3">
              <v-img :src="component.urlImg" aspect-ratio="1"/>
          </v-col>

          <v-col cols="8">
            <v-card-title class="custom-title">{{component.title}}</v-card-title>
            <v-divider/>
            <v-card-text>
              {{component.description}}
            </v-card-text>
          </v-col>
        </v-row>    
      </v-card>
      <v-pagination v-model="currentPage" class="my-4" :length="totalPages"></v-pagination>
</div>
</v-container>



</template>

<style>

.image-container {
  width: 200px; /* Define el ancho del cuadro de imagen */
  height: 200px; /* Define la altura del cuadro de imagen */
  border-radius: 12px; /* Bordes curvos */
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
        totalPages: 3,
        resultPerPage: 3,
      }
    },
    watch: {
    currentPage() {
    this.searchComponent();
    },
  },

    created(){

        this.searchComponent();
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
          axios.get(`/api/Components/Search?searchText=${this.$route.params.search}&pageResults=${this.resultPerPage}&page=${this.currentPage}`).then(response => {
        this.components = response.data;
      }).catch(error => {
        console.error(error);
      });
        }
        axios.get(`/api/${this.$route.params.component}`).then(response => {
        this.components = response.data
        // this.totalPages = Math.ceil(parseInt(this.components.length) / 3);
        console.log(this.components.length / 3);

        }).catch(error => {
        console.error(error);
        });
      },
    }
  }
</script>
