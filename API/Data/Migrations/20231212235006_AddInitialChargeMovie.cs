using CineVerse.API.Data;
using CineVerse.API.Models;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialChargeMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new DataContext();
            context.Movie.AddRange(GetInitialCharge());
            context.SaveChanges();
        }

        private static IList<Movie> GetInitialCharge() => new List<Movie>
        {
            new() {
                Title = "Tempo de Matar",
                OriginalTitle = "A Time to Kill",
                Synopsis = "Em Canton, Mississippi, um jovem advogado e seu assistente defendem um homem negro acusado de assassinar dois homens brancos que estupraram sua filha de dez anos, incitando retaliação violenta e vingança da Ku Klux Klan.",
                PosterPath = "API/Assets/Images/a-time-to-kill.jpg",
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
                PosterPath = "API/Assets/Images/the-rainmaker.jpg",
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
                PosterPath = "API/Assets/Images/the-firm.jpg",
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
                PosterPath = "API/Assets/Images/wall-street.jpg",
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
                PosterPath = "API/Assets/Images/jfk.jpg",
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
                PosterPath = "API/Assets/Images/shutter-island.jpg",
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
                PosterPath = "API/Assets/Images/planet-of-the-apes.jpg",
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
                PosterPath = "API/Assets/Images/true-grit.jpg",
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
                PosterPath = "API/Assets/Images/seven-years-in-tibet.jpg",
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
                PosterPath = "API/Assets/Images/i-robot.jpg",
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
                PosterPath = "API/Assets/Images/edge-of-tomorrow.jpg",
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
                PosterPath = "API/Assets/Images/the-great-wall.jpg",
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
                PosterPath = "API/Assets/Images/kingdom-of-heaven.jpg",
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
                PosterPath = "API/Assets/Images/jurassic-park.jpg",
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
                PosterPath = "API/Assets/Images/dances-with-wolves.jpg",
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
                PosterPath = "API/Assets/Images/titanic.jpg",
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
                PosterPath = "API/Assets/Images/war-of-the-worlds.jpg",
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
                PosterPath = "API/Assets/Images/conviction.jpg",
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
                PosterPath = "API/Assets/Images/alien.jpg",
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
                PosterPath = "API/Assets/Images/everest.jpg",
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
    }
}
