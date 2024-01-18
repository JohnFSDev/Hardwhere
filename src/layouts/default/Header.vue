<template>
    <v-app-bar color="#FFB703" :elevation="4">
      <a href="/">
        <v-img
          :width="250"
          cover
          src="/hw_logo.png"
        />
      </a>
        
          <v-text-field
            v-model="search"
            :loading="loading"
            density="compact"
            label="Buscar"
            append-inner-icon="mdi-magnify"
            hide-details     
            variant = "solo"    
            class ="bg-white"
            @click:append-inner = "UserSearch()"
          ></v-text-field>
          
      <a style="color: #023047; margin: 0 30px;">¿Qué es Hardwhere?</a>
    </v-app-bar>
    <busqueda :components="components" :search-value="search" @parametros-ruta =  "DataSearch"/>
</template>

<style>

</style>

<script lang="ts">

  import axios from 'axios'
  import busqueda from '@/components/Busqueda.vue'

  export default {
    components:{
      busqueda,
    },
    data: () => ({
      loaded: false,
      loading: false,
      search: '',
      components: null, 
    }),
    methods: {
      onClick () {
        this.loading = true

        setTimeout(() => {
          this.loading = false
          this.loaded = true
        }, 2000)
      },
      mounted(){
        this.DataSearch()
      },
      async DataSearch(){
        await axios.get(`/api/${this.$route.params.component}`).then(response => {
        this.components = response.data
        console.log(response.data);
        }).catch(error => {
        console.error(error);
        })
      },
      async UserSearch() {
        
        console.log(this.search);
      await axios.get(`/api/Components/Search?searchText=${this.search}&pageResults=3&page=1`).then(response => {
        this.components = response.data;
        this.$router.push('/search')
        console.log(response.data);

      }).catch(error => {
        console.error(error);
      });
    },
  }
}

</script>
