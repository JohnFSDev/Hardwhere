<template>
    <v-app-bar color="#FFB703" :elevation="4">
      <router-link to="/" >
        <v-img
          :width="250"
          cover
          src="/hw_logo.png"
        ></v-img>
      </router-link>
      <a href="/" >
        

      </a>
          <v-text-field
            :loading="loading"
            density="compact"
            label="Buscar"
            append-inner-icon="mdi-magnify"
            hide-details     
            variant = "solo"    
            class ="bg-white"
            @click:append-inner = "onClick"
          ></v-text-field>
      <a style="color: #023047; margin: 0 30px;">¿Qué es Hardwhere?</a>
    </v-app-bar>
</template>

<style>

</style>

<script lang="ts">
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
