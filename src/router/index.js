import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home'
//import About from '../views/About' //importado de outra maneira
import ListMatriculaComponent from '../components/list-matricula/ListMatriculaComponent'
import CreateMatriculaComponent from '../components/create-matricula/CreateMatriculaComponent'
import EditMatriculaComponent from '../components/edit-matricula/EditMatriculaComponent'
import ListDisciplinaComponent from '../components/list-disciplina/ListDisciplinaComponent'

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
    component: ListMatriculaComponent
  },
  {
    path: '/create-matricula',
    name: 'Create Matricula',
    component: CreateMatriculaComponent
  },
  {
    path: '/edit-matricula/:ra',
    name: 'Edit Matricula',
    component: EditMatriculaComponent
  },
  {
    path: '/list-disciplina',
    name: 'List Disciplina',
    component: ListDisciplinaComponent
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
