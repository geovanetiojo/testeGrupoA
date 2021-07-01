import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  {
    path: '/list-matricula',
    name: 'List Matricula',
    component: () => import('../components/list-matricula/ListMatriculaComponent')
  },
  {
    path: '/create-matricula',
    name: 'Create Matricula',
    component: () => import('../components/create-matricula/CreateMatriculaComponent')
  },
  {
    path: '/edit-matricula/:ra',
    name: 'Edit Matricula',
    component: () => import('../components/edit-matricula/EditMatriculaComponent')
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
