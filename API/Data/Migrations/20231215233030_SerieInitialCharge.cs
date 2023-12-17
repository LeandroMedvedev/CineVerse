using CineVerse.API.Data;
using CineVerse.API.Models;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class SerieInitialCharge : Migration
    {
        /// <inheritdoc />
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
    }
}
