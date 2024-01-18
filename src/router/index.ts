// Composables
import { createRouter, createWebHistory } from 'vue-router'
const routes = [
  {
    path: '/',
    component: () => import('@/layouts/default/Default.vue'),
    children: [
      {
        path: '',
        name: 'Home',
        // route level code-splitting
        // this generates a separate chunk (Home-[hash].js) for this route
        // which is lazy-loaded when the route is visited.
        component: () => import('@/views/Home.vue'),
      },
      {
        path: '/Components/:id',
        name: 'Resultado',
        component: () => import('@/views/Resultado.vue'), // Asegúrate de importar correctamente tu componente Search.vue
      },
      {
        path: ':component', // Ruta dinámica con un parámetro
        name: 'SpecificComponent',
        component: () => import('@/views/Search.vue'), // Vista principal
      },
      {
        path: '/Search/:search',
        name: 'SearchComponent',
        component: () => import('@/views/Search.vue'), // Vista principal
      }

    ],
    
  },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
})

export default router
