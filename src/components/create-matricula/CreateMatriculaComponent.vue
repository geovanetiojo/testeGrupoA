<template>
    <v-container>
        <h1>Create new Matricula</h1>            
        <v-row>
            <v-col
                cols=6
            >
                <v-form class="text-center">

                    <v-text-field
                        v-model="ra"
                        label="RA"
                        outline
                        :rules="raRules"
                        placeholder="Informe o Registro Acadêmico"
                        clearable
                        required
                    ></v-text-field>

                    <v-text-field
                        v-model="cpf"
                        label="CPF"
                        :rules="cpfRules"
                        placeholder="Informe o número do documento"
                        clearable
                        outline
                        required
                    ></v-text-field>

                    <v-text-field
                        v-model="nome"
                        label="Nome"                        
                        :rules="nomeRules"
                        outline
                        placeholder="Informe o nome completo"
                        clearable
                        required
                    ></v-text-field>

                    <v-text-field
                        v-model="email"
                        label="E-mail"        
                        outline                
                        :rules="emailRules"
                        placeholder="Informe apenas um e-mail"
                        clearable
                        required
                    ></v-text-field>

                    <v-btn
                        color="success"
                        class="justify-space-between"
                        round 
                    >
                        Salvar
                    </v-btn>

                    <v-btn
                        round
                        class="justify-space-between"
                        color="error"                                                 
                    >
                        Cancelar
                    </v-btn>

                </v-form>
            </v-col>
        </v-row>
    </v-container>
    
</template>

<script>
export default {
    components: {
        //name: 'CreateMatriculaComponent',
    },
    data ()  {
        return {
            matricula: {
                ra: '',
                cpf: '',
                nome: '',
                email: '',
            },
            raRules: [
                value => !!value || 'O RA é obrigatório',
                //value => (value && value.length >= 3) || 'O RA deve ter no mínimo 3 caracteres',
                value => (value && value.length == 10) || 'O RA deve ter 10 caracteres'
            ],
            nomeRules: [
                value => !!value || 'O nome é obrigatório',
                //value => (value && value.length >= 3) || 'O nome deve ter no mínimo 3 caracteres',
                //value => (value && value.length <= 10) || 'O nome deve ter menos do que 10 caracteres'
            ],
            emailRules: [
                value => !!value || 'O e-mail é obrigatório',
                value => /.+@.+\..+/.test(value) || 'O e-mail não é válido',
            ],
            cpfRules: [
                value => !!value || 'O CPF é obrigatória',
                value => (value && value.length == 14) || 'A CPF deve ter no 14 caracteres com . e -'
            ]
        };
  },
};

</script>