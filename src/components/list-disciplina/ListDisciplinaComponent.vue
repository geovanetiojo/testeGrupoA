<template>
  <v-container>
    <titulo texto="Lista de Disciplinas" />
    <v-row>
      <v-col cols="6">
        <v-text-field v-model="search" label="" type="text"> </v-text-field>
      </v-col>
      <v-col cols="2">
        <v-btn
          color="info"
          class="justify-space-between"
          :loading="loading"
          :disabled="loading"
          @click="loader = 'loading'"
        >
          Pesquisar
          <v-icon right dark>search</v-icon>
        </v-btn>
      </v-col>
      <v-col cols="1"> </v-col>
      <v-col cols="2">
        <v-btn
          color="orange"
          class="justify-space-between"
          @click="register = 'loading'"
          to="/create-matricula"
        >
          Cadastrar Novo
        </v-btn>
      </v-col>
    </v-row>
    <v-row>
      <v-col cols="12">
        <v-simple-table>
          <template v-slot:default>
            <thead>
              <tr>
                <th class="text-left">ID</th>
                <th class="text-left">NOME</th>       
                <th class="text-left">CURSO</th>
                <th class="text-left">AÇÕES</th>                         
              </tr>
            </thead>
            <tbody v-if="disciplinas.length">
              <tr v-for="(disciplina, index) in disciplinas" :key="index">
                <td>{{disciplina.id}}</td>
                <td>{{disciplina.nome}}</td>
                <td>{{disciplina.curso}}</td>
                <td><v-btn
                      color="yellow"
                      class="justify-space-between"
                      @click="register = 'loading'"
                      :to="`/edit-matricula/${disciplina.id}`"
                      
                    >
                      Editar
                    </v-btn>
                    <v-btn
                      color="red"
                      class="justify-space-between"
                      @click="remover(disciplina)"
                      
                    >
                      Excluir
                    </v-btn>
                    </td>
              </tr>
            </tbody>
            <tfoot v-else>
                  <tr>
                    <td colspan="3" style="text-align: center">
                      <h5>Nenhuma Disciplina Encontrada</h5>
                    </td>
                  </tr>
                </tfoot>
          </template>
          
        </v-simple-table>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import Titulo from "../_share/Titulo";

export default {
  components: {
    Titulo,
  },
  data() {
    return {
      loader: null,
      loading: false,
      loading2: false,
      loading3: false,
      loading4: false,
      disciplinas: [{id: 1, nome: 'Calculo I', curso:'Engenharia'}
                    ,{id: 2, nome: 'Estrutura de Dados', curso:'Ciências da Computação'}
                    ,{id: 3, nome: 'Anatomia', curso:'Medicina'}
              ]
    };
  },
  watch: {
    loader() {
      const l = this.loader;
      this[l] = !this[l];

      setTimeout(() => (this[l] = false), 3000);

      this.loader = null;
    },
  },
  props: {},
  methods: {
    remover(disciplina) {
      let indice = this.disciplinas.indexOf(disciplina);
      this.disciplinas.splice(indice,1);
      // this.$http.delete(`http://localhost:5000/api/aluno/${aluno.id}`).then(() => {
      //   let indice = this.alunos.indexOf(aluno);
      //   this.alunos.splice(indice, 1);
      // });
      
    },
    
  },
};
</script>