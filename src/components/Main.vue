<template>
  <!-- Contenedor flex para los cards -->
  <!-- Este es el contenedor de las rams -->
  <div class="card-container">

    <a href="Rams">
      <v-card 
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
    </a>




  <a href="GraphicCard">
    <v-card
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
  </a>

    
  <a href="Supply">
    <v-card
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
</a>
  
  <a href="StorageMemory">
    <v-card
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
</a>

  <a href="Processor">
    
    <v-card
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
    
</a>

  </div>
</template>

<script>

export default {
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
