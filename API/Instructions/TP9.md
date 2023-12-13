# Teste de Performance 9

Olá, Dev!!!

Que tal começarmos a entender o ciclo de vida de desenvolvimento de software através da construção de um projeto do zero? Vamos entender como funciona esse desenvolvimento durante as diferentes etapas do processo, qual a necessidade de cada artefato e como podemos chegar às novas tendências de programação através dessa modelagem. 

Faremos isso tudo na nossa disciplina de Projeto de Bloco Desenvolvimento Back-End organizada em 10 features:

Feature 01 - Definição do Projeto
Feature 02 - Elaboração da lista de requisitos
Feature 03 - Criação do diagrama de caso de uso
Feature 04 - Análise de entidades
Feature 05 - Criação do diagrama de classes
Feature 06 - Criação do diagrama de estados
Feature 07 - Criação do diagrama de atividades
Feature 08 - Implementação do Back-End - Parte I
**Feature 09 - Implementação do Back-End - Parte II**  
Feature 10 - Implementação do Back-End - Parte III

Esse TP representa a Feature 09 e você precisa atualizar o documento com o repositório do github e implementar as seguintes necessidades:

Criação do banco e mapeamento das classes em entidade
Criação dos relacionamentos entre entidades
Criação da camada de banco
Substituição do Map por banco de dados
Para aumentar o nível de detalhamento do que precisa ser implementado, leia a documentação apresentada a seguir:

FEATURE 09

Essa feature é essencial para a consolidação do sistema, pois estabelece uma base de dados sólida, configura relacionamentos importantes entre as entidades e prepara o sistema para operações avançadas, como consultas complexas e a manutenção eficiente de dados. Isso permite ao sistema de gestão de pedidos controlar informações de maneira mais escalável e eficaz. Ela abrange as seguintes tarefas essenciais:

Parte 1: Criação do banco e mapeamento das classes em entidade

Criação do banco de dados e configuração do datasource para acesso e manipulação: 

Inicialmente, um banco de dados será criado e configurado para possibilitar o armazenamento e a recuperação de dados do sistema. Isso envolve a escolha de um sistema de gerenciamento de banco de dados (DBMS), como MySQL, PostgreSQL ou outro, e a configuração de um dataSource para permitir a comunicação com o banco.

Mapeamento das classes de domínio em entidades do banco: 

As classes de domínio criadas na primeira feature serão mapeadas em entidades do banco de dados. Isso implica em definir como os atributos de cada classe correspondem às colunas do banco e como os relacionamentos entre as entidades serão refletidos no esquema do banco de dados.

Parte 2: Criação dos relacionamentos entre entidades

Criar o relacionamento oneToMany ou manyToMany entre as entidades de pedido e de produto:

Será estabelecido um relacionamento "one-to-many" ou "many-to-many" entre as entidades de "pedido" e "produto". Isso significa que um pedido pode estar associado a vários produtos, enquanto um produto pertence a vários pedidos.

Criar o relacionamento de herança entre a classe de produto e as suas filhas: 

Para lidar com diferentes tipos de produtos (por exemplo, produtos físicos e produtos digitais), será estabelecido um relacionamento de herança entre a classe "Produto" e suas subclasses. Isso permite que as características específicas de cada tipo de produto sejam modeladas de forma eficiente.

Parte 3: Criação da camada de banco

Criação das interfaces @Repository para possibilitar o uso das funcionalidades de banco de dados da CrudRepository: 

Serão criadas interfaces anotadas com @Repository para as entidades do banco de dados. Essas interfaces estenderão a CrudRepository, proporcionando operações de CRUD (Create, Read, Update, Delete) padrão para as entidades.

Atuar na injeção de dependência dos repositories nas classes de serviço: 

Os repositórios criados na etapa anterior serão injetados nas classes de serviço correspondentes. Isso permitirá que as classes de serviço acessem o banco de dados de maneira eficiente, implementando as operações de negócios relacionadas a cada entidade.

Parte 4: Substituição do Map por banco de dados

Desconsiderar a estrutura Map após a realização da injeção de dependência dos repositories: 

Após a injeção de dependência dos repositories, a estrutura de dados Map, usada na primeira feature para simular o armazenamento temporário, pode ser desconsiderada. As operações de armazenamento e recuperação de dados agora serão realizadas diretamente no banco de dados.

Atualizar as classes Loader para relacionar os produtos cadastrados com os pedidos existentes: 

As classes Loader criadas na primeira feature precisam ser atualizadas para preencher o banco de dados com dados relacionados. Isso envolve associar os produtos cadastrados aos vendedores existentes por meio dos relacionamentos definidos.

Assim que terminar, salve o seu texto em um arquivo PDF e poste na etapa correspondente no Moodle respeitando a seguinte nomenclatura:“nome_sobrenome_PB_TP9.PDF”.