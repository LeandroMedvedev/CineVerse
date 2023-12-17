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



### Migrations
AddInitialChargeCustomer

protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new DataContext();
            
            context.Customer.AddRange(GetInitialCharge());
            context.SaveChanges();
        }

        private static IList<Customer> GetInitialCharge()
        {
            var password = "wW*8uuuu";
            var john = new string[2] {"John", "Locke"};
            var hugo = new string[2] {"Hugo", "Reyes"};
            var kate = new string[2] {"Kate", "Austen"};
            var jack = new string[2] {"Jack", "Shephard"};
            var james = new string[2] {"James", "Sawyer"};
            var sayid = new string[2] {"Sayid", "Jarrah"};
            var desmond = new string[2] {"Desmond", "Hume"};
            var benjamin = new string[2] {"Benjamin", "Linus"};

            return new List<Customer>()
            {
                new()
                {
                    Email = $"{john[1].ToLower()}{john[0].ToLower()}@lost.com",
                    UserName = $"{john[0].ToLower()}{john[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = john[0],
                    LastName = john[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{hugo[1].ToLower()}{hugo[0].ToLower()}@lost.com",
                    UserName = $"{hugo[0].ToLower()}{hugo[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = hugo[0],
                    LastName = hugo[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{kate[1].ToLower()}{kate[0].ToLower()}@lost.com",
                    UserName = $"{kate[0].ToLower()}{kate[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = kate[0],
                    LastName = kate[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{james[1].ToLower()}{james[0].ToLower()}@lost.com",
                    UserName = $"{james[0].ToLower()}{james[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = james[0],
                    LastName = james[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{sayid[1].ToLower()}{sayid[0].ToLower()}@lost.com",
                    UserName = $"{sayid[0].ToLower()}{sayid[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = sayid[0],
                    LastName = sayid[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{jack[1].ToLower()}{jack[0].ToLower()}@lost.com",
                    UserName = $"{jack[0].ToLower()}{jack[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = jack[0],
                    LastName = jack[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{desmond[1].ToLower()}{desmond[0].ToLower()}@lost.com",
                    UserName = $"{desmond[0].ToLower()}{desmond[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = desmond[0],
                    LastName = desmond[1],
                    Password = password,
                },
                new()
                {
                    Email = $"{benjamin[1].ToLower()}{benjamin[0].ToLower()}@lost.com",
                    UserName = $"{benjamin[0].ToLower()}{benjamin[1].ToLower()}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FirstName = benjamin[0],
                    LastName = benjamin[1],
                    Password = password,
                },
            };
        }


**AddInitialChargeMovie**

protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new DataContext();
            context.Movie.AddRange(GetInitialCharge());
            context.SaveChanges();
        }

        private static IList<Movie> GetInitialCharge() => new List<Movie>
        {
            new() 
            {
                Title = "Tempo de Matar",
                OriginalTitle = "A Time to Kill",
                Synopsis = "Em Canton, Mississippi, um jovem advogado e seu assistente defendem um homem negro acusado de assassinar dois homens brancos que estupraram sua filha de dez anos, incitando retaliação violenta e vingança da Ku Klux Klan.",
                PosterPath = "API/Assets/Images/Movies/a-time-to-kill.jpg",
                Runtime = "2h29min",
                Premiere = new DateTime(1996, 7, 24),
                Classification = "14 anos",
                Genre = "Thriller, Ficção Policial",
                Price = 19.99f,
                BasedOnRealFacts = true,
                BasedOnBooks = true,
                Dubbed = false
            },
            new()
            {                    
                Title = "O Homem que Fazia Chover",
                OriginalTitle = "The Rainmaker",
                Synopsis = "Um advogado recém-formado trabalha em seu primeiro caso contra uma companhia de seguros que suspende o plano de saúde de uma vítima de leucemia. O profissional idealista enfrentará júris intensos e lutará a favor dos princípios morais em sua batalha contra a corrupção.",
                PosterPath = "API/Assets/Images/Movies/the-rainmaker.jpg",
                Runtime = "2h15min",
                Premiere = new DateTime(1997, 11, 18),
                Classification = "12 anos",
                Genre = "Crime, Drama",
                Price = 17.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = true
            },
            new()
            {
                Title = "A Firma",
                OriginalTitle = "The Firm",
                Synopsis = "Um jovem advogado começa a trabalhar em um renomado escritório, mas descobre que a maioria dos clientes está do lado errado da lei. A empresa ajuda a esconder dinheiro de mafiosos, retira acusações de clientes culpados e mata quem ameaça os expor. Mas quando o FBI começa a reunir provas contra os colegas do advogado, ele fica em uma situação difícil.",
                PosterPath = "API/Assets/Images/Movies/the-firm.jpg",
                Runtime = "2h34min",
                Premiere = new DateTime(1993, 6, 30),
                Classification = "14 anos",
                Genre = "Thriller, Mistério",
                Price = 12.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = true
            },
            new()
            {
                Title = "Wall Street - Poder e Cobiça",
                OriginalTitle = "Wall Street",
                Synopsis = "Bud Fox é um corrector da bolsa que quer enriquecer e torna-se pupilo de Gordon Gekko, tubarão das finanças com uma filosofia amoral. Mas num mundo de ganância e poucos escrúpulos, terá de agir contra a sua moral ou perder o que conseguiu.",
                PosterPath = "API/Assets/Images/Movies/wall-street.jpg",
                Runtime = "2h06min",
                Premiere = new DateTime(1987, 12, 10),
                Classification = "14 anos",
                Genre = "Drama, Crime",
                Price = 24.99f,
                BasedOnRealFacts = true,
                BasedOnBooks = false,
                Dubbed = false
            },
            new()
            {
                Title = "JFK - A Pergunta Que Não Quer Calar",
                OriginalTitle = "JFK: Oliver Stone's JFK",
                Synopsis = "A investigação do assassinato do presidente John F. Kennedy liderada pelo promotor público de Nova Orleans, Jim Garrison (Kevin Costner). Quando Garrison começa a duvidar da conjectura sobre o crime, ele se depara com a resistência do governo. Após o suspeito do assassinato de Kennedy, Lee Harvey Oswald (Gary Oldman), ser morto, o caso é encerrado. Mais tarde, porém, Garrison reabre a investigação e encontra provas de uma grande conspiração por trás da morte do presidente.",
                PosterPath = "API/Assets/Images/Movies/jfk.jpg",
                Runtime = "3h26min",
                Premiere = new DateTime(1991, 12, 20),
                Classification = "14 anos",
                Genre = "Mistério",
                Price = 12.99f,
                BasedOnRealFacts = true,
                BasedOnBooks = false,
                Dubbed = false
            },
            new()
            {                    
                Title = "Ilha do Medo",
                OriginalTitle = "Shutter Island",
                Synopsis = "Nos anos 1950, a fuga de uma assassina leva o detetive Teddy Daniels e seu parceiro a investigarem o seu desaparecimento de um quarto trancado em um hospital psiquiátrico. Lá, uma rebelião se inicia e o agente terá que enfrentar seus próprios medos.",
                PosterPath = "API/Assets/Images/Movies/shutter-island.jpg",
                Runtime = "2h18min",
                Premiere = new DateTime(2010, 2, 14),
                Classification = "16 anos",
                Genre = "Thriller, Mistério",
                Price = 29.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = true
            },
            new()
            {
                Title = "Planeta dos Macacos",
                OriginalTitle = "Planet of the Apes",
                Synopsis = "Depois de sofrer um acidente com sua espaçonave, Leo Davidson consegue chegar a um planeta diferente, aparentemente cruel, onde seres humanos são caçados e escravizados por primatas e têm de se esforçar muito para conquistar seus meios de subsistência. Ao ver tudo aquilo, Leo fica indignado com a opressão imposta aos humanos. Ele logo propõe uma revolução, tornando-se uma enorme ameaça ao status quo do planeta.",
                PosterPath = "API/Assets/Images/Movies/planet-of-the-apes.jpg",
                Runtime = "1h59min",
                Premiere = new DateTime(2001, 7, 27),
                Classification = "12 anos",
                Genre = "Ficção científica, Aventura",
                Price = 14.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = true
            },
            new()
            {
                Title = "Bravura Indômita",
                OriginalTitle = "True Grit",
                Synopsis = "Mattie Ross, uma menina de 14 anos, contrata o veterano xerife Rooster Cogburn para ajudá-la a encontrar Tom Chaney, o homem que assassinou o seu pai. A dupla briguenta não está sozinha em sua busca: um texano chamado LaBoeuf também vem monitorando Chaney por razões próprias. Juntos, o trio se aventura em um território hostil na caçada ao bandido.",
                PosterPath = "API/Assets/Images/Movies/true-grit.jpg",
                Runtime = "1h50min",
                Premiere = new DateTime(2010, 12, 22),
                Classification = "16 anos",
                Genre = "Faroeste, Ação",
                Price = 14.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = false
            },
            new()
            {
                Title = "Seven Years in Tibet",
                OriginalTitle = "Seven Years in Tibet",
                Synopsis = "A história do alpinista Heinrich Harrer, cuja tentativa de escalar o pico do Himalaia é interrompida pela Segunda Guerra. Depois de muitas aventuras, ele se encontra no Tibet, onde faz amizade com o Dalai Lama, ganhando maturidade e humildade.",
                PosterPath = "API/Assets/Images/Movies/seven-years-in-tibet.jpg",
                Runtime = "2h16min",
                Premiere = new DateTime(1997, 9, 12),
                Classification = "14 anos",
                Genre = "Aventura, Guerra",
                Price = 14.99f,
                BasedOnRealFacts = true,
                BasedOnBooks = true,
                Dubbed = false
            },
            new()
            {
                Title = "Eu, Robô",
                OriginalTitle = "I, Robot",
                Synopsis = "Em 2035, é comum robôs serem usados como empregados e assistentes dos humanos. Para manter a ordem, esses robôs possuem um código que impede a violência contra humanos, a chamada Lei dos Robóticos. Quando Dr. Miles aparece morto e o principal suspeito é justamente um robô, acredita-se na possibilidade de que eles tenham encontrado um meio de desativar essa programação.",
                PosterPath = "API/Assets/Images/Movies/i-robot.jpg",
                Runtime = "1h55min",
                Premiere = new DateTime(2004, 7, 15),
                Classification = "10 anos",
                Genre = "Ficção Científica, Ação",
                Price = 12.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = false
            },
            new()
            {
                Title = "No Limite do Amanhã",
                OriginalTitle = "Edge of Tomorrow",
                Synopsis = "Em uma guerra contra alienígenas, William Cage descobre que tem a estranha habilidade de voltar no tempo, ficando preso em um eterno ciclo. Ele treina para usar suas novas habilidades, derrotar os invasores e acabar com a guerra.",
                PosterPath = "API/Assets/Images/Movies/edge-of-tomorrow.jpg",
                Runtime = "1h53min",
                Premiere = new DateTime(2014, 6, 6),
                Classification = "14 anos",
                Genre = "Ação, Ficção Científica",
                Price = 19.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = true
            },
            new()
            {
                Title = "A Grande Muralha",
                OriginalTitle = "The Great Wall",
                Synopsis = "Um grupo de soldados britânicos está lutando na China e se depara com o início das construções da Grande Muralha. Eles percebem que o intuito não é apenas proteger a população do inimigo mongol e que a construção esconde na verdade um grande segredo.",
                PosterPath = "API/Assets/Images/Movies/the-great-wall.jpg",
                Runtime = "1h43min",
                Premiere = new DateTime(2016, 12, 16),
                Classification = "12 anos",
                Genre = "Ação, Aventura",
                Price = 24.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = false,
                Dubbed = true
            },
            new()
            {
                Title = "Cruzada",
                OriginalTitle = "Kingdom of Heaven",
                Synopsis = "Ainda em luto pela repentina morte de sua esposa, o ferreiro Balian junta-se ao seu distante pai, Baron Godfrey, nas cruzadas a caminho de Jerusalém. Após uma jornada muito difícil até à cidade santa, o jovem valente entra no séquito do rei leproso Balduíno IV, que deseja lutar contra os muçulmanos para seu próprio ganho político e pessoal.",
                PosterPath = "API/Assets/Images/Movies/kingdom-of-heaven.jpg",
                Runtime = "2h24min",
                Premiere = new DateTime(2005, 5, 6),
                Classification = "14 anos",
                Genre = "Ação, Aventura",
                Price = 24.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = true
            },
            new()
            {
                Title = "Jurassic Park - Parque dos Dinossauros",
                OriginalTitle = "Jurassic Park",
                Synopsis = "Os paleontólogos Alan Grant, Ellie Sattler e o matemático Ian Malcolm fazem parte de um seleto grupo escolhido para visitar uma ilha habitada por dinossauros criados a partir de DNA pré-histórico. O idealizador do projeto e bilionário John Hammond garante a todos que a instalação é completamente segura. Mas após uma queda de energia, os visitantes descobrem, aos poucos, que vários predadores ferozes estão soltos e à caça.",
                PosterPath = "API/Assets/Images/Movies/jurassic-park.jpg",
                Runtime = "2h07min",
                Premiere = new DateTime(1993, 6, 11),
                Classification = "12 anos",
                Genre = "Aventura, Ficção Científica",
                Price = 14.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = true
            },
            new()
            {
                Title = "Dança com Lobos",
                OriginalTitle = "Dances with Wolves",
                Synopsis = "No período da Guerra Civil Americana, o jovem militar John Dunbar cria uma estratégia não violenta de aproximação com índios Sioux. Os indígenas, que acham curiosa a amizade de Dunbar com um lobo, passam a conviver de forma afetuosa com o tenente.",
                PosterPath = "API/Assets/Images/Movies/dances-with-wolves.jpg",
                Runtime = "3h56min",
                Premiere = new DateTime(1990, 3, 30),
                Classification = "14 anos",
                Genre = "Faroeste, Guerra",
                Price = 12.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = false
            },
            new()
            {
                Title = "Titanic",
                OriginalTitle = "Titanic",
                Synopsis = "Um artista pobre e uma jovem rica se conhecem e se apaixonam na fatídica viagem inaugural do Titanic em 1912.Embora esteja noiva do arrogante herdeiro de uma siderúrgica, a jovem desafia sua família e amigos em busca do verdadeiro amor.",
                PosterPath = "API/Assets/Images/Movies/titanic.jpg",
                Runtime = "3h14min",
                Premiere = new DateTime(1997, 12, 19),
                Classification = "12 anos",
                Genre = "Drama, Romance",
                Price = 19.99f,
                BasedOnRealFacts = true,
                BasedOnBooks = false,
                Dubbed = true
            },
            new()
            {
                Title = "Guerra dos Mundos",
                OriginalTitle = "War of the Worlds",
                Synopsis = "Ray Ferrier é um estivador divorciado, afastado de seus filhos, que vivem com a mãe. Quando sua ex-esposa deixa as crianças para ele cuidar durante alguns dias, o planeta é atacado por alienígenas que surgem do chão conduzindo tripods e destruindo tudo que encontram pelo caminho. Ray tenta proteger os seus filhos e fugir para Boston para se juntar à sua ex-esposa. Durante o trajeto, enfrenta várias adversidades e ataques.",
                PosterPath = "API/Assets/Images/Movies/war-of-the-worlds.jpg",
                Runtime = "1h56min",
                Premiere = new DateTime(2005, 6, 28),
                Classification = "12 anos",
                Genre = "Ficção científica, Ação",
                Price = 14.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = true,
                Dubbed = true
            },
            new()
            {
                Title = "A Condenação",
                OriginalTitle = "Conviction",
                Synopsis = "A garçonete Betty Anne Waters deixa sua vida de lado para tentar livrar o irmão de uma acusação de assassinato. Convencida da inocência dele, ela começa a estudar direito para assumir o caso e libertá-lo.",
                PosterPath = "API/Assets/Images/Movies/conviction.jpg",
                Runtime = "1h47min",
                Premiere = new DateTime(2010, 10, 15),
                Classification = "14 anos",
                Genre = "Thriller, Drama",
                Price = 12.99f,
                BasedOnRealFacts = true,
                BasedOnBooks = true,
                Dubbed = false
            },
            new()
            {
                Title = "Alien, o Oitavo Passageiro",
                OriginalTitle = "Alien, the Eighth Passenger",
                Synopsis = "Uma nave espacial, ao retornar para Terra, recebe estranhos sinais vindos de um asteroide. Enquanto a equipe investiga o local, um dos tripulantes é atacado por um misterioso ser. O que parecia ser um ataque isolado se transforma em um terror constante, pois o tripulante atacado levou para dentro da nave o embrião de um alienígena, que não para de crescer e tem como meta matar toda a tripulação.",
                PosterPath = "API/Assets/Images/Movies/alien.jpg",
                Runtime = "1h57min",
                Premiere = new DateTime(1979, 8, 20),
                Classification = "14 anos",
                Genre = "Terror, Ficção Científica",
                Price = 19.99f,
                BasedOnRealFacts = false,
                BasedOnBooks = false,
                Dubbed = true
            },
            new()
            {
                Title = "Evereste",
                OriginalTitle = "Everest",
                Synopsis = "Em maio de 1996, escaladores de duas expedições diferentes começam a subir em direção ao cume do Monte Everest, mas logo se veem lutando por suas vidas em uma nevasca mortal.",
                PosterPath = "API/Assets/Images/Movies/everest.jpg",
                Runtime = "2h01min",
                Premiere = new DateTime(2015, 9, 17),
                Classification = "12 anos",
                Genre = "Aventura, Thriller",
                Price = 16.99f,
                BasedOnRealFacts = true,
                BasedOnBooks = true,
                Dubbed = false
            }            
        };


**AddInitialChargeSerie**

protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new DataContext();
            context.Serie.AddRange(GetInitialCharge());
            context.SaveChanges();
        }

        private static IList<Serie> GetInitialCharge() => new List<Serie>
        {
            new()
            {
                Title = "Lost",
                OriginalTitle = "Lost",
                Synopsis = "Os sobreviventes de um voo que estava milhas fora do curso caem em uma ilha que abriga um sistema de segurança monstruoso, uma série de abrigos subterrâneos e um grupo de sobrevivencialistas violentos escondidos nas sombras.",
                PosterPath = "API/Assets/Images/Series/lost.jpg",
                Runtime = "45min",
                Premiere = new DateTime(2004, 9, 22),
                Classification = "14 anos",
                Genre = "Drama",
                Price = 199.99,
                Awarded = true,
                Seasons = "6",
                Episodes = "121"
            },
            new()
            {
                Title = "Seinfeld",
                OriginalTitle = "Seinfeld",
                Synopsis = "Quatro amigos solteiros, o comediante Jerry Seinfeld, o atrapalhado George Constanza, a trabalhadora frustrada Elaine Benes e o excêntrico vizinho Cosmo Kramer, lidam com os absurdos da vida cotidiana em Nova York.",
                PosterPath = "API/Assets/Images/Series/seinfeld.jpg",
                Runtime = "22min",
                Premiere = new DateTime(1989, 7, 5),
                Classification = "10 anos",
                Genre = "Comédia",
                Price = 199.99,
                Awarded = true,
                Seasons = "9",
                Episodes = "173"
            },
            new()
            {
                Title = "Dawson's Creek",
                OriginalTitle = "Dawson's Creek",
                Synopsis = "Quatro amigos em uma pequena cidade costeira traçam uma jornada da adolescência à vida adulta. Juntos, eles lidam com diferentes problemas que os fazem amadurecer.",
                PosterPath = "API/Assets/Images/Series/dawsons-creek.jpg",
                Runtime = "44min",
                Premiere = new DateTime(1998, 1, 20),
                Classification = "12 anos",
                Genre = "Drama, Romance",
                Price = 199.99,
                Awarded = true,
                Seasons = "6",
                Episodes = "128"
            },
            new()
            {
                Title = "Breaking Bad",
                OriginalTitle = "Breaking Bad",
                Synopsis = "O professor de química Walter White não acredita que sua vida possa piorar ainda mais. Quando descobre que tem câncer terminal, Walter decide arriscar tudo para ganhar dinheiro enquanto pode, transformando sua van em um laboratório de metanfetamina.",
                PosterPath = "API/Assets/Images/Series/breaking-bad.jpg",
                Runtime = "47min",
                Premiere = new DateTime(2008, 1, 20),
                Classification = "16 anos",
                Genre = "Policial, Drama, Suspense",
                Price = 99.99,
                Awarded = true,
                Seasons = "5",
                Episodes = "62"
            },
            new()
            {
                Title = "Spartacus",
                OriginalTitle = "Spartacus",
                Synopsis = "A lenda de Spartacus está escrita no sangue e na areia da arena. Um poderoso guerreiro trácio traído por um ambicioso legado romano, Spartacus é escravizado, forçado a se tornar um gladiador se quiser ver sua esposa novamente. Na escola de gladiadores do maquiavélico Batiatus e sua esposa Lucretia, Spartacus será ensinado pelo implacável Doctore a se tornar o mais formidável dos combatentes. Mas entre a hostilidade dos outros gladiadores e os esquemas de Lucretia, Spartacus terá que sacrificar tudo para sobreviver.",
                PosterPath = "API/Assets/Images/Series/spartacus.jpg",
                Runtime = "53min",
                Premiere = new DateTime(2010, 1, 22),
                Classification = "18 anos",
                Genre = "Drama, Guerra, Épico",
                Price = 87.99,
                Awarded = false,
                Seasons = "3",
                Episodes = "33"
            },
            new()
            {
                Title = "Game of Thrones",
                OriginalTitle = "Game of Thrones",
                Synopsis = "Sucesso entre os livros mais vendidos, a série de obras \"A Song of Ice and Fire\", de George R.R. Martin, é levada à tela quando HBO decide navegar a fundo pelo gênero e recriar a fantasia medieval épica. Este é o retrato de duas famílias poderosas - reis e rainhas, cavaleiros e renegados, homens honestos e mentirosos - disputando um jogo mortal pelo controle dos Sete Reinos de Westeros para assumir o Trono de Ferro. A série foi filmada em Malta e no norte da Irlanda, tendo participação do escritor dos livros.",
                PosterPath = "API/Assets/Images/Series/game-of-thrones.jpg",
                Runtime = "60min",
                Premiere = new DateTime(2011, 4, 17),
                Classification = "18 anos",
                Genre = "Fantasia, Drama",
                Price = 129.99,
                Awarded = true,
                Seasons = "8",
                Episodes = "73"
            },
            new()
            {
                Title = "Vikings",
                OriginalTitle = "Vikings",
                Synopsis = "A série acompanha a saga dos navegadores nórdicos que exploram - e conquistam - novos territórios nos tempos medievais.",
                PosterPath = "API/Assets/Images/Series/vikings.jpg",
                Runtime = "45min",
                Premiere = new DateTime(2013, 3, 3),
                Classification = "16 anos",
                Genre = "Ação, Drama, Aventura",
                Price = 107.99,
                Awarded = false,
                Seasons = "6",
                Episodes = "89"
            },
            new()
            {
                Title = "Friends",
                OriginalTitle = "Friends",
                Synopsis = "Seis amigos, três homens e três mulheres, enfrentam a vida e os amores em Nova York e adoram passar o tempo livre na cafeteria Central Perk.",
                PosterPath = "API/Assets/Images/Series/friends.jpg",
                Runtime = "22min",
                Premiere = new DateTime(1994, 9, 22),
                Classification = "12 anos",
                Genre = "Comédia, Romance",
                Price = 179.99,
                Awarded = true,
                Seasons = "10",
                Episodes = "236"
            },
            new()
            {
                Title = "Barrados no Baile",
                OriginalTitle = "Beverly Hills, 90210",
                Synopsis = "Acompanhe os conflitos, tragédias, romances e dilemas de um grupo de jovens que moram na cidade rica e elitista de Beverly Hills, desde o ensino médio até a vida adulta. Eles se tornam amigos e inimigos, se apaixonam e se decepcionam, passam por triângulos amorosos e outras complicações românticas, têm problemas familiares e precisam tomar decisões sobre o futuro.",
                PosterPath = "API/Assets/Images/Series/beverly-hills-90210.jpg",
                Runtime = "45min",
                Premiere = new DateTime(1990, 10, 4),
                Classification = "14 anos",
                Genre = "Drama, Romance",
                Price = 189.99,
                Awarded = false,
                Seasons = "10",
                Episodes = "293"
            },
            new()
            {
                Title = "The Big Bang Theory",
                OriginalTitle = "The Big Bang Theory",
                Synopsis = "Os melhores amigos e companheiros de apartamento Leonard e Sheldon são físicos que trabalham no Instituto Tecnológico da Califórnia (Caltech) e são capazes de explicar a todo mundo mais do que gostariam de saber sobre física quântica, mas superar as situações sociais mais básicas, especialmente aquelas envolvendo mulheres, os deixa completamente perdidos. Que sorte quando a garçonete/atriz aspirante Penny se muda para o apartamento ao lado. Wolowitz e Koothrappali, também da Caltech, são vistos frequentemente passando o tempo com Leonard e Sheldon. Será que os mundos vão se colidir? Será que Einstein teorizava na floresta?",
                PosterPath = "API/Assets/Images/Series/big-bang-theory.jpg",
                Runtime = "22min",
                Premiere = new DateTime(2007, 9, 24),
                Classification = "12 anos",
                Genre = "Comédia",
                Price = 156.99,
                Awarded = true,
                Seasons = "12",
                Episodes = "279"
            },
            new()
            {
                Title = "The Wire",
                OriginalTitle = "The Wire",
                Synopsis = "Esta série criada por um ex-repórter policial acompanha o trabalho de um detetive de homicídios em Baltimore que leva criminosos à justiça através de grampo telefônico, além de outras táticas modernas e inovadoras.",
                PosterPath = "API/Assets/Images/Series/the-wire.jpg",
                Runtime = "60min",
                Premiere = new DateTime(2002, 6, 2),
                Classification = "14 anos",
                Genre = "Crime, Drama",
                Price = 79.99,
                Awarded = true,
                Seasons = "5",
                Episodes = "60"
            },
            new()
            {
                Title = "Um Maluco na TV / 30 Rock",
                OriginalTitle = "30 Rock",
                Synopsis = "Vagamente baseada em experiências de Tina Fey como argumentista do programa de televisão humorístico \"Saturday Night Live\", \"Um Maluco na TV\" foca na jovem Liz Lemon, redatora-chefe de um esquete de comédia ao vivo em Nova York. As complicações surgem quando o novo presidente da rede ordena que Liz contrate o astro de cinema mentalmente instável Tracy Jordan para se juntar ao elenco com a neurótica protagonista (e melhor amiga de Liz) Jenna Maroney. Liz tenta controlar todos os egos ao seu redor enquanto persegue os próprios sonhos.",
                PosterPath = "API/Assets/Images/Series/30-rock.jpg",
                Runtime = "22min",
                Premiere = new DateTime(2006, 10, 11),
                Classification = "14 anos",
                Genre = "Comédia",
                Price = 124.99,
                Awarded = true,
                Seasons = "7",
                Episodes = "138"
            },
            new()
            {
                Title = "Chernobyl",
                OriginalTitle = "Chernobyl",
                Synopsis = "Homens e mulheres corajosos agem heroicamente para mitigar danos catastróficos quando a Usina Nuclear de Chernobyl sofre um acidente nuclear em 25 de abril de 1986.",
                PosterPath = "API/Assets/Images/Series/chernobyl.jpg",
                Runtime = "60min",
                Premiere = new DateTime(2019, 5, 6),
                Classification = "16 anos",
                Genre = "Drama, História, Thriller",
                Price = 59.99,
                Awarded = true,
                Seasons = "1",
                Episodes = "5"
            },
            new()
            {
                Title = "C.S.I.: Investigação Criminal",
                OriginalTitle = "C.S.I.: Crime Scene Investigation",
                Synopsis = "Um dedicado grupo de investigadores forenses em um laboratório criminal de Las Vegas se empenha para resolver crimes quase sempre macabros. Trabalhando no turno da noite está o supervisor D.B. Russell, um verdadeiro Sherlock Holmes que devora livros de mistério e assassinatos. Os integrantes da equipe de Russell incluem Catherine Willows, Nick Stokes, Sara Sidle (a bússola moral do grupo), Greg Sanders e Morgan Brody. O time trabalha de perto com o capitão Jim Brass, um detetive experiente. Entre os chefes anteriores do grupo estão Gus Grissom e o Dr. Raymond Langston.",
                PosterPath = "API/Assets/Images/Series/csi.jpg",
                Runtime = "40min",
                Premiere = new DateTime(2000, 10, 6),
                Classification = "14 anos",
                Genre = "Crime, Drama, Mistério",
                Price = 189.99,
                Awarded = true,
                Seasons = "15",
                Episodes = "337"
            },
            new()
            {
                Title = "Chicago Fire: Heróis contra o Fogo",
                OriginalTitle = "Chicago Fire",
                Synopsis = "Integrantes do corpo de bombeiros de Chicago se culpam pela morte de um companheiro e enfrentam problemas pessoais, mas, apesar das tensões, na hora de enfrentar os desafios, deixam as diferenças de lado e arriscam suas vidas.",
                PosterPath = "API/Assets/Images/Series/chicago-fire.jpg",
                Runtime = "43min",
                Premiere = new DateTime(2012, 10, 10),
                Classification = "14 anos",
                Genre = "Ação, Drama",
                Price = 126.99,
                Awarded = false,
                Seasons = "10",
                Episodes = "213"
            },
            new()
            {
                Title = "Criminal Minds",
                OriginalTitle = "Criminal Minds",
                Synopsis = "Um esquadrão de elite do FBI estuda as maiores mentes criminosas, antecipando seus próximos passos, antes que eles ataquem novamente. A fim de identificar as motivações dos criminosos e detê-los, cada membro da equipe usa a experiência que possui.",
                PosterPath = "API/Assets/Images/Series/criminal-minds.jpg",
                Runtime = "42min",
                Premiere = new DateTime(2005, 9, 22),
                Classification = "14 anos",
                Genre = "Crime, Drama, Mistério",
                Price = 199.99,
                Awarded = true,
                Seasons = "15",
                Episodes = "323"
            },
            new()
            {
                Title = "Mare of Easttown",
                OriginalTitle = "Mare of Easttown",
                Synopsis = "Uma detetive de uma pequena cidade investiga um assassinato local enquanto sua vida desmorona.",
                PosterPath = "API/Assets/Images/Series/mare-of-easttown.jpg",
                Runtime = "60min",
                Premiere = new DateTime(2021, 4, 18),
                Classification = "14 anos",
                Genre = "Crime, Drama, Mistério",
                Price = 49.99,
                Awarded = true,
                Seasons = "1",
                Episodes = "7"
            },
            new()
            {
                Title = "Castle",
                OriginalTitle = "Castle",
                Synopsis = "Entediado com o seu sucesso, o badalado escritor de histórias de mistério Rick Castle se une à detetive do NYPD Kate Beckett para solucionar o caso de um assassino que recria cenas de homicídio descritas nos livros de Rick. Enquanto solucionam o caso, os dois realizam que a parceria incomum tem seus benefícios e decidem continuar trabalhando juntos. Combinando a intuição de escritor com o trabalho criativo de detetive, a dupla investiga estranhos homicídios em Nova York. Durante o tempo todo, os dois desenvolvem um relacionamento forte porém complicado.",
                PosterPath = "API/Assets/Images/Series/castle.jpg",
                Runtime = "43min",
                Premiere = new DateTime(2009, 3, 9),
                Classification = "14 anos",
                Genre = "Crime, Drama, Comédia",
                Price = 137.99,
                Awarded = false,
                Seasons = "8",
                Episodes = "173"
            },
            new()
            {
                Title = "Lie to Me",
                OriginalTitle = "Lie to Me",
                Synopsis = "Principal pesquisador do mundo sobre comportamentos mentirosos e evasivos, Dr. Cal Lightman estuda as expressões faciais, linguagem corporal e tons da voz para poder determinar quando uma pessoa está mentindo e o porquê.",
                PosterPath = "API/Assets/Images/Series/lie-to-me.jpg",
                Runtime = "43min",
                Premiere = new DateTime(2009, 1, 21),
                Classification = "14 anos",
                Genre = "Crime, Drama, Mistério",
                Price = 89.99,
                Awarded = false,
                Seasons = "3",
                Episodes = "48"
            },
            new()
            {
                Title = "Dr. House",
                OriginalTitle = "House, M.D.",
                Synopsis = "No fictício Hospital-Escola Plainsboro de Princeton, no estado de Nova Jersey, o gênio afiado Dr. Gregory House ataca mistérios de saúde como o faria um Sherlock Holmes médico. Tudo isso enquanto se engaja em jogos mentais com os colegas, como o melhor amigo, o oncologista James Wilson. House, um amargurado especialista em doenças infecciosas, desvenda mistérios médicos com a ajuda de uma equipe de jovens profissionais. Instinto perfeito e raciocínio não-convencional trazem grande respeito a House, apesar de sua honestidade brutal e tendências antissociais.",
                PosterPath = "API/Assets/Images/Series/dr-house.jpg",
                Runtime = "44min",
                Premiere = new DateTime(2004, 11, 16),
                Classification = "14 anos",
                Genre = "Drama, Mistério",
                Price = 139.99,
                Awarded = true,
                Seasons = "8",
                Episodes = "177"
            },
        };












### CODE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CineVerse.API.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task<int> AddMovieAsync(Movie movie);
        Task UpdateMovieAsync(int id, Movie updatedMovie);
        Task DeleteMovieAsync(int id);
    }

    public class MovieService : IMovieService
    {
        private readonly YourDbContext _context;

        public MovieService(YourDbContext context)
        {
            _context = context;
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            return await _context.Movies.FirstOrDefaultAsync(m => m.MovieId == id);
        }

        public async Task<int> AddMovieAsync(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return movie.MovieId;
        }

        public async Task UpdateMovieAsync(int id, Movie updatedMovie)
        {
            var existingMovie = await _context.Movies.FirstOrDefaultAsync(m => m.MovieId == id);

            if (existingMovie != null)
            {
                existingMovie.Title = updatedMovie.Title;
                existingMovie.OriginalTitle = updatedMovie.OriginalTitle;
                // Atualize outras propriedades conforme necessário

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteMovieAsync(int id)
        {
            var movieToDelete = await _context.Movies.FirstOrDefaultAsync(m => m.MovieId == id);

            if (movieToDelete != null)
            {
                _context.Movies.Remove(movieToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
