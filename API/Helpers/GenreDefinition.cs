namespace CineVerse.API.Helpers;

public class GenreDefinition
{
    public string Value { get; private set; }

    private GenreDefinition(string value) { Value = value; }

    public static GenreDefinition Action
    {
        get
        {
            return new GenreDefinition(
                "Gênero com intensa atividade física, incluindo lutas, perseguições de carros e explosões."
            );
        }
    }
    public static GenreDefinition Adventure
    {
        get
        {
            return new GenreDefinition(
                "Gênero que envolve viagens ou experiências emocionantes e muitas vezes arriscadas."
            );
        }
    }
    public static GenreDefinition ArtCinema
    {
        get
        {
            return new GenreDefinition(
                "Gênero caracterizado por técnicas cinematográficas inovadoras e artísticas."
            );
        }
    }
    public static GenreDefinition Chanchada
    {
        get
        {
            return new GenreDefinition(
                "Comédias musicais brasileiras populares das décadas de 1930 a 1950."
            );
        }
    }
    public static GenreDefinition Comedy
    {
        get
        {
            return new GenreDefinition(
                "Gênero concebido para entreter e divertir, muitas vezes com humor e sátira."
            );
        }
    }
    public static GenreDefinition ActionComedy
    {
        get
        {
            return new GenreDefinition(
                "Gênero que combina elementos de ação e comédia."
            );
        }
    }
    public static GenreDefinition HorrorComedy
    {
        get
        {
            return new GenreDefinition(
                "Gênero que mistura elementos de terror e comédia."
            );
        }
    }
    public static GenreDefinition DramaticComedy
    {
        get
        {
            return new GenreDefinition(
                "Gênero com mistura de drama e comédia."
            );
        }
    }
    public static GenreDefinition RomanticComedy
    {
        get
        {
            return new GenreDefinition(
                "Gênero que combina elementos de romance e comédia."
            );
        }
    }
    public static GenreDefinition Dance
    {
        get
        {
            return new GenreDefinition(
                "Gênero focado em apresentações de dança e coreografias."
            );
        }
    }
    public static GenreDefinition Documentary
    {
        get
        {
            return new GenreDefinition(
                "Gênero que apresenta informações factuais sobre eventos, pessoas ou questões reais."
            );
        }
    }
    public static GenreDefinition Documentation
    {
        get
        {
            return new GenreDefinition(
                "Gênero que fornece documentos ou registros, muitas vezes de forma sistemática ou abrangente."
            );
        }
    }
    public static GenreDefinition Drama
    {
        get
        {
            return new GenreDefinition(
                "Gênero caracterizado por uma narrativa séria e profundidade emocional."
            );
        }
    }
    public static GenreDefinition Espionage
    {
        get
        {
            return new GenreDefinition(
                "Gênero envolvendo atividades de espionagem e agentes secretos."
            );
        }
    }
    public static GenreDefinition Western
    {
        get
        {
            return new GenreDefinition(
                "Gênero ambientado no Velho Oeste americano, geralmente apresentando cowboys e bandidos."
            );
        }
    }
    public static GenreDefinition Fantasy
    {
        get
        {
            return new GenreDefinition(
                "Gênero com elementos mágicos ou sobrenaturais em um cenário fictício."
            );
        }
    }
    public static GenreDefinition ScientificFantasy
    {
        get
        {
            return new GenreDefinition(
                "Gênero com elementos imaginativos e especulativos fundamentados na ciência."
            );
        }
    }
    public static GenreDefinition ScienceFiction
    {
        get
        {
            return new GenreDefinition(
                "Gênero que explora conceitos científicos futuristas ou especulativos."
            );
        }
    }
    public static GenreDefinition MoviesWithTricks
    {
        get
        {
            return new GenreDefinition(
                "Gênero conhecido por suas reviravoltas inteligentes ou elementos surpresa."
            );
        }
    }
    public static GenreDefinition WarFilms
    {
        get
        {
            return new GenreDefinition(
                "Gênero que retrata as experiências da guerra e seu impacto nos indivíduos."
            );
        }
    }
    public static GenreDefinition Mystery
    {
        get
        {
            return new GenreDefinition(
                "Gênero centrado na resolução de um mistério ou crime."
            );
        }
    }
    public static GenreDefinition Musical
    {
        get
        {
            return new GenreDefinition(
                "Gênero com música e muitas vezes números de dança elaborados."
            );
        }
    }
    public static GenreDefinition CrimeFilm
    {
        get
        {
            return new GenreDefinition(
                "Gênero focado em atividades criminais, investigações e justiça."
            );
        }
    }
    public static GenreDefinition Romance
    {
        get
        {
            return new GenreDefinition(
                "Gênero centrado em amor, relacionamentos e experiências românticas."
            );
        }
    }
    public static GenreDefinition Horror
    {
        get
        {
            return new GenreDefinition(
                "Gênero concebido para evocar medo e suspense através de elementos sobrenaturais ou macabros."
            );
        }
    }
    public static GenreDefinition Thriller
    {
        get
        {
            return new GenreDefinition(
                "Gênero destinado a entusiasmar, entreter e manter o público em suspense."
            );
        }
    }

    public override string ToString() => Value;        
}
