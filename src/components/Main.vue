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
            style="width: 600px; border: transparent;"
            @click:append-inner="onClick"
          ></v-text-field>
        </v-card-text>
      </v-card>
      <a color="#023047">Qué es Hardwhere?</a>
    </v-app-bar>
  </v-toolbar>

  <!-- Contenedor flex para los cards -->
  <div class="card-container">
    <v-card
      :loading="loading"
      :class="'RAM'"
      class="my-12 card-item"
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
        src="/computer-ram.jpg"
        class="object-fit-contain"
        style="max-width: 100%; max-height: 100%;"
      ></v-img>

      <v-card-title
        class="text-center title-background"
      >Memoria Ram</v-card-title>
    </v-card>

    <v-card
      :loading="loading"
      :class="'Graf'"
      class="my-12 card-item"
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
        src="/Graf.png"
        class="object-fit-contain"
        style="max-width: 100%; max-height: 100%;"
      ></v-img>

      <v-card-title
        class="text-center title-background"
      >Tarjeta Gráfica</v-card-title>
    </v-card>

    <v-card
    :loading="loading"
    :class="'Graf'"
    class="my-12 card-item"
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
      src="/ps.png"
      class="object-fit-contain"
      style="max-width: 100%; max-height: 100%;"
    ></v-img>

    <v-card-title
      class="text-center title-background"
    >Fuentes de Poder</v-card-title>
  </v-card>

  <v-card
  :loading="loading"
  :class="'Graf'"
  class="my-12 card-item"
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
    src="/m2.jpg"
    class="object-fit-contain"
    style="max-width: 100%; max-height: 100%;"
  ></v-img>

  <v-card-title
    class="text-center title-background"
  >Memorias de Almacenamiento</v-card-title>
</v-card>

<v-card
:loading="loading"
:class="'Graf'"
class="my-12 card-item"
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
  src="/i9.jpg"
  class="object-fit-contain"
  style="max-width: 100%; max-height: 100%;"
></v-img>

<v-card-title
  class="text-center title-background"
>Procesadores</v-card-title>
</v-card>
  </div>
</template>

<script>
export default {
  data: () => ({
    loaded: false,
    loading: false,
  }),

  methods: {
    onClick() {
      this.loading = true;
      setTimeout(() => {
        this.loading = false;
        this.loaded = true;
      }, 2000);
    },
  },
};
</script>

<style>
.card-container {
  display: flex;
  justify-content: center;
  gap: 100px;
  flex-wrap: wrap;
  margin-top: 20px;
}

.card-item {
  width: 250px;
  height: 250px;
  position: relative;
}

.title-background {
  position: absolute;
  bottom: 0;
  width: 100%;
  background-color: rgba(255, 255, 255, 0.8);
}
</style>
