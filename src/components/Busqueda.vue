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
    <a href="#">Que es Hardwhere</a>
    </v-app-bar>
  </v-toolbar>

  <v-card>
    <v-row no-gutters>
      <!-- Columna para la imagen -->
      <v-col cols="4">
        <v-img src="https://picsum.photos/200/300" aspect-ratio="2.75"></v-img>
      </v-col>
  
      <!-- Columna para el contenido -->
      <v-col cols="8">
        <v-card-title>Nombre Componente</v-card-title>
        <v-card-text>
          Descripcion Componente
        </v-card-text>
      </v-col>
    </v-row>
  </v-card>

  <v-divider></v-divider>

          <template>
            <v-footer style="background-color: #023047;">
<a> Inicio de la pagina </a>            </v-footer>
          </template>
          

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