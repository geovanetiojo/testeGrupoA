<template>
    <v-container>
    
      <v-row>
        <v-col
          cols=3  
            hight=5000
        >
          <v-card
            height="600"
            
          >
            <v-card-title class="text-h5">
              Módulo Acadêmico
            </v-card-title>
            
            <v-card-actions>
              <v-btn text>
                Aluno
              </v-btn>
            </v-card-actions> 
          </v-card>
        </v-col>
        <v-col
          cols=9
        >
          <v-card
            height="600"
          >
            <v-card-title class="text-h5">
              Lista
            </v-card-title>
            <ListMatriculaComponent class="mt-5" />
            <CreateMatriculaComponent class="mt-5" />
            <EditMatriculaComponent class="mt-5" />
          </v-card>
        </v-col>
      </v-row>
      <v-row>
        
      </v-row>
    
    </v-container>
</template>

<script>
  import ListMatriculaComponent from "../components/list-matricula/ListMatriculaComponent";
  import CreateMatriculaComponent from "../components/create-matricula/CreateMatriculaComponent";
  import EditMatriculaComponent from "../components/edit-matricula/EditMatriculaComponent";


  export default {
    data: () => ({
      
    }),
    components: {
      ListMatriculaComponent,CreateMatriculaComponent,EditMatriculaComponent
    }
  }
</script>