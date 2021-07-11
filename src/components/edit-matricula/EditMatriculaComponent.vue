<template>
    <v-container>
        <titulo texto="Editar Matrícula"  />             
        <v-row>
            <v-col
                cols=6
            >
                <v-form class="text-center">

                    <v-text-field
                        v-model=this.ra_param
                        outline
                        label="RA"
                        :rules="raRules"
                        placeholder="Informe o Registro Acadêmico"
                        readonly
                        required                        
                    ></v-text-field>

                    <v-text-field
                        v-model=ra
                        outline
                        label="CPF"
                        :rules="cpfRules"
                        placeholder="Informe o número do documento"
                        readonly
                        required
                    ></v-text-field>

                    <v-text-field
                        v-model=nome
                        outline
                        label="Nome"                        
                        :rules="nomeRules"
                        placeholder="Informe o nome completo"
                        clearable
                        required
                    ></v-text-field>
                 
                    <v-text-field
                        v-model="email"
                        outline
                        label="E-mail"                        
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
                        to="/list-matricula"                                           
                    >
                        Cancelar
                    </v-btn>

                </v-form>
            </v-col>
        </v-row>
    </v-container>
</template>

<script>
import Titulo from "../_share/Titulo";

    export default {
        components: {
            
            Titulo
        },
        data ()  {
            return {
                alunos: [{ra: 1, nome: 'Jão', cpf:'123123123'}
                         ,{ra: 2, nome: 'José', cpf:'111111111'}
                         ,{ra: 3, nome: 'Maria', cpf:'22222222'}
                        ],
                ra_param: this.$route.params.ra,
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
        created() {
            this.carregarAluno();
        },
        methods: {
            carregarAluno() {
                
            }
        },
    };
</script>