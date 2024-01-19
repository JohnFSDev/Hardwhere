<template>
  <!-- Contenedor flex para los cards -->
  <!-- Este es el contenedor de las rams -->
  <div class="card-container">

    <router-link to="Rams">
      <v-card class="my-12 card-item" max-width="400" height="250">
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>
 
      <v-img src="/computer-ram.jpg" height="200"/>

 
    <v-divider :thickness="5" ></v-divider>

    <v-card-title class="text-center title-background">
      Tarjeta Gráfica
    </v-card-title>

  </v-card>
    </router-link>

    <!-- Este es el contenedor de tarjetas graficas -->
    <router-link to="GraphicCard">
      <v-card class="my-12 card-item" max-width="250" height="250">
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>
 
      <v-img src="/Graf.png" height="200"/>

 
    <v-divider :thickness="5" ></v-divider>

    <v-card-title class="text-center title-background">
      Tarjeta Gráfica
    </v-card-title>

  </v-card>
 </router-link>

    
 <router-link to="Supply">
  <v-card class="my-12 card-item" max-width="250" height="250">
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>
 
      <v-img src="/ps.png" height="200"/>

 
    <v-divider :thickness="5" ></v-divider>

    <v-card-title class="text-center title-background">
      Tarjeta Gráfica
    </v-card-title>

  </v-card>
 </router-link>
  
 <router-link to="StorageMemory">
  <v-card class="my-12 card-item" max-width="250" height="250">
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>
 
      <v-img src="/m2.jpg" height="200"/>

 
    <v-divider :thickness="5" ></v-divider>

    <v-card-title class="text-center title-background">
      Tarjeta Gráfica
    </v-card-title>

  </v-card>
 </router-link>

 <router-link to="Processor">
  <v-card class="my-12 card-item" max-width="250" height="250">
    <template v-slot:loader="{ isActive }">
      <v-progress-linear
        :active="isActive"
        color="deep-purple"
        height="4"
        indeterminate
      ></v-progress-linear>
    </template>
 
      <v-img src="/procesador.jpg" height="200"/>

 
    <v-divider :thickness="5" ></v-divider>

    <v-card-title class="text-center title-background">
      Tarjeta Gráfica
    </v-card-title>

  </v-card>
 </router-link>

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
