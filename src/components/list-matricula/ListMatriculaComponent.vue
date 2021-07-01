<template>
    <v-container>
        <h1>List Matricula</h1>  
        <v-row>
            <v-col
                cols=6
            >
                <v-text-field
                v-model="search"
                label=""
                type="text"
                
                >
                
                </v-text-field> 
            </v-col>
            <v-col
               cols=2
            >
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
            <v-col
               cols=1
            >
                
            </v-col>
            <v-col
               cols=2
            >
                <v-btn
                    color="orange" 
                    class="justify-space-between"
                    @click="register = 'loading'"
                >
                    Cadastrar Novo
                </v-btn>
            </v-col>
        </v-row>      
        <v-row>
        <v-col
            cols=12
        >

        </v-col>
        </v-row>   
    </v-container>
    
    
</template>

<script>
  export default {
    data () {
      return {
        loader: null,
        loading: false,
        loading2: false,
        loading3: false,
        loading4: false
      }
    },
    watch: {
      loader () {
        const l = this.loader
        this[l] = !this[l]

        setTimeout(() => (this[l] = false), 3000)

        this.loader = null
      }
    }
  }
</script>