# Good Luck!

1  - Realizar a instalação dos programas:
    vscode
    node.js
    git bash
    sdk
    vue
    vuetify
    dotnet
    postgressql

2 - Execução de comandos no terminal como:
    npm install -g @vue/cli
    vue create hello-world
    vue add vuetify
    npm run server

3- Execução de comando do git para "commitar" projeto - terminal git bash
    cd NomedaPasta/NomedeOutraPasta/nomeDaPastaDoProjeto/
    git init
    git status
    git add .
    git commit -m 'Escrever comentário'
    git remote add origin 'https://github.com/usuario/nomedomeuprojeto.git'
    git remote show origin -n
    git push origin master

A utilização destes 3 passos acima, não exatamente nesta ordem, mas foi o que consegui fazer e muito do que aprendi neste espaço de tempo de uma semana, com exceção da plataforma VSCODE que já utilizava, mas praticamente somente como um editor de texto para arquivos htmls e javascript. Não foi nada fácil ter que apredender e me desenvolver isso sozinho, seguindo tutoriais e video na internet.

Segue abaixo sobre o projeto em si:
    Especificações Técnicas
        Front End: Vuetifyjs como framework de UI - ok
        API: .netCore, C# e Entity framework - ok, cheguei a instalar no projeto, mas não foi implementado 
        Banco de Dados: Postgress ou MySQL - escolhi o postgres, até mesmo para ver como é a ferramenta e somente cria tabela basica e inseri algumas infomações manualmente
        Idioma de escrita do código: Inglês - ok
    
    Mockups de interface
        Criado o um espécie de CRUD como componentes (criar, editar e listar), mas somente interfaces
        Criado um Home e um About, no Home seria a página principal de menus e crud, e um abaut sobre informações da página, criador, etc.
        Quase uma possível tela de login, para separar os usuários admin e outros

    Cenário:
        Apenas consegui fazer as interfaces, formulários, algumas navegações, validações, mas como não consegui desenvolver o back-end, não foi possível inserir, atualizar, apagar, listar informações do banco de dados

    Campos obrigatórios:
        Nome (editável) - ok
        Email (editável) - ok
        RA (não editável) (chave única) - ok
        CPF (não editável) - ok

Teria que melhorar tudo no meu projeto, principalmente fazer funcionar a comunicação do front e back end.
Sobrre o desafio, como é um projeto somente de teste, o cenário está bem simples do que realmente é a realidade, quantidade de campos necessário, dúvidas como em realmente excluir, por que nào ativar e desativar o cadastro, um cpf pode ter mais de um RA ativo, poderá excluir um ra se estiver intergrado em outra tabela, por exemplo, 'turma'


    



