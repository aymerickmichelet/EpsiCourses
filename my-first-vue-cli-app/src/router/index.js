import { createRouter, createWebHashHistory } from 'vue-router'
import Home from '../views/Home.vue'

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/read',
    name: 'Read',
    component: () => import('../views/Read.vue')
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
