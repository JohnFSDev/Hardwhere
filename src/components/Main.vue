<template>
  <v-toolbar>
  <v-app-bar color="#FFB703" :elevation="0">
    <img src="/hw_logo.png" height="270" />
    <v-card
    class="mx-auto"
    color="grey-lighten-3"
    max-width="700"
  >
    <v-card-text>
      <v-text-field
        :loading="loading"
        density="compact"
        variant="solo"
        label="Buscar"
        append-inner-icon="mdi-magnify"
        single-line
        hide-details
        style="width: 600px;"
        @click:append-inner="onClick"
      ></v-text-field>
    </v-card-text>
  </v-card>
  <a to="/2nda">Qué es Hardwhere</a>  </v-app-bar>
</v-toolbar>

<v-card
    :loading="loading"
    :class="'RAM'"
    class="mx-auto my-12"
    max-width="250"
    height="250"
  >
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>

    <v-img
      src="https://picsum.photos/500/250"
      class="object-fit-contain"
      style="max-width: 250px; max-height: 250px; width: auto; height: auto;"
    ></v-img>

    <v-card-item
    max-width="250"
    height="250"
    >
      <v-card-title
      class="text-center"
      >Memoria Ram</v-card-title>
    </v-card-item>
  </v-card>

  <v-card
    :loading="loading"
    :class="'GRAF'"
    class="mx-auto my-12"
    max-width="250"
    height="250"
  >
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>

    <v-img
      src="https://picsum.photos/500/250"
      class="object-fit-contain"
      style="max-width: 250px; max-height: 250px; width: auto; height: auto;"
    ></v-img>

    <v-card-item
    max-width="250"
    height="250"
    >
      <v-card-title
      class="text-center"
      >Tarjeta Grafica</v-card-title>
    </v-card-item>
  </v-card>

  <v-card
    :loading="loading"
    :class="'Fuente'"
    class="mx-auto my-12"
    max-width="250"
    height="250"
  >
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>

    <v-img
      src="https://picsum.photos/500/250"
      class="object-fit-contain"
      style="max-width: 250px; max-height: 250px; width: auto; height: auto;"
    ></v-img>

    <v-card-item
    max-width="250"
    height="250"
    >
      <v-card-title
      class="text-center"
      >Fuente de Poder</v-card-title>
    </v-card-item>
  </v-card>

  <v-card
    :loading="loading"
    :class="'ROM'"
    class="mx-auto my-12"
    max-width="250"
    height="250"
  >
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>

    <v-img
      src="https://picsum.photos/500/250"
      class="object-fit-contain"
      style="max-width: 250px; max-height: 250px; width: auto; height: auto;"
    ></v-img>

    <v-card-item
    max-width="250"
    height="250"
    >
      <v-card-title
      class="text-center"
      >Memoria Almacenamiento</v-card-title>
    </v-card-item>
  </v-card>

  <v-card
    :loading="loading"
    :class="'Procesador'"
    class="mx-auto my-12"
    max-width="250"
    height="250"
  >
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>

    <v-img
      src="https://picsum.photos/500/250"
      class="object-fit-contain"
      style="max-width: 250px; max-height: 250px; width: auto; height: auto;"
    ></v-img>

    <v-card-item
    max-width="250"
    height="250"
    >
      <v-card-title
      class="text-center"
      >Procesadores</v-card-title>
    </v-card-item>
  </v-card>
  
</template>

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

<style>
.card {
  /* Estilos para el card */
  /* ... */
}

.image-container {
  width: 250px; /* Ancho deseado para la imagen */
  height: 250px; /* Altura deseada para la imagen */
  overflow: hidden; /* Oculta el contenido que se desborda */
  margin: 0 auto;
}

.square-image {
  width: 100%; /* Ocupa todo el ancho del contenedor */
  height: 100%; /* Ocupa todo el alto del contenedor */
  object-fit: cover; /* Recorta la imagen según el tamaño del contenedor */
}
</style>
