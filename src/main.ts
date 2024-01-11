// Plugins
import { registerPlugins } from '@/plugins'

// Components
import App from './App.vue'
import axios from 'axios'
axios.defaults.baseURL = 'https://localhost:7289'
import VueCookies from 'vue-cookies'

// Composables
import { createApp } from 'vue'

const app = createApp(App)

registerPlugins(app)
app.use(VueCookies,{expires: '1d'})
app.mount('#app')
