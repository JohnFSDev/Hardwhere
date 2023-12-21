import { createApp } from 'vue'
import './style.css'
import App from './App.vue'
import PortalVue from 'portal-vue'

createApp(App).mount('#app')
App.use(PortalVue)
App.mount('#app')
