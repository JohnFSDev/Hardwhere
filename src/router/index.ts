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
        path: '/search',
        name: 'Search',
        component: () => import('@/views/Search.vue'), // Asegúrate de importar correctamente tu componente Search.vue
      },
      {
        path: '/resultado',
        name: 'Resultado',
        component: () => import('@/views/Resultado.vue'), // Asegúrate de importar correctamente tu componente Search.vue
      },
    ],
  },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
})

export default router
