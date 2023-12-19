using CineVerse.API.Enums;

namespace CineVerse.API.Extensions;

public static class GenreDescriptionExtension
{
    public static string GetDescription(this GenreDescription genre)
      => genre switch
      {
          GenreDescription.Action
           => "Gênero com intensa atividade física, incluindo lutas, perseguições de carros e explosões.",
          GenreDescription.Adventure
           => "Gênero que envolve viagens ou experiências emocionantes e muitas vezes arriscadas.",
          GenreDescription.ArtCinema
           => "Gênero caracterizado por técnicas cinematográficas inovadoras e artísticas.",
          GenreDescription.Chanchada
           => "Comédias musicais brasileiras populares das décadas de 1930 a 1950.",
          GenreDescription.Comedy
           => "Gênero concebido para entreter e divertir, muitas vezes com humor e sátira.",
          GenreDescription.ActionComedy
           => "Gênero que combina elementos de ação e comédia.",
          GenreDescription.HorrorComedy
           => "Gênero que mistura elementos de terror e comédia.",
          GenreDescription.DramaticComedy
           => "Gênero com mistura de drama e comédia.",
          GenreDescription.RomanticComedy
           => "Gênero que combina elementos de romance e comédia.",
          GenreDescription.Dance
           => "Gênero focado em apresentações de dança e coreografias.",
          GenreDescription.Documentary
           => "Gênero que apresenta informações factuais sobre eventos, pessoas ou questões reais.",
          GenreDescription.Documentation
           => "Gênero que fornece documentos ou registros, muitas vezes de forma sistemática ou abrangente.",
          GenreDescription.Drama
           => "Gênero caracterizado por uma narrativa séria e profundidade emocional.",
          GenreDescription.Espionage
           => "Gênero envolvendo atividades de espionagem e agentes secretos.",
          GenreDescription.Western
           => "Gênero ambientado no Velho Oeste americano, geralmente apresentando cowboys e bandidos.",
          GenreDescription.Fantasy
           => "Gênero com elementos mágicos ou sobrenaturais em um cenário fictício.",
          GenreDescription.ScientificFantasy
           => "Gênero com elementos imaginativos e especulativos fundamentados na ciência.",
          GenreDescription.ScienceFiction
           => "Gênero que explora conceitos científicos futuristas ou especulativos.",
          GenreDescription.MovieswithTricks
           => "Gênero conhecido por suas reviravoltas inteligentes ou elementos surpresa.",
          GenreDescription.WarFilms
           => "Gênero que retrata as experiências da guerra e seu impacto nos indivíduos.",
          GenreDescription.Mystery
           => "Gênero centrado na resolução de um mistério ou crime.",
          GenreDescription.Musical
           => "Gênero com música e muitas vezes números de dança elaborados.",
          GenreDescription.CrimeFilm
           => "Gênero focado em atividades criminais, investigações e justiça.",
          GenreDescription.Romance
           => "Gênero centrado em amor, relacionamentos e experiências românticas.",
          GenreDescription.Horror
           => "Gênero concebido para evocar medo e suspense através de elementos sobrenaturais ou macabros.",
          GenreDescription.Thriller
           => "Gênero destinado a entusiasmar, entreter e manter o público em suspense.",
          _
           => throw new ArgumentOutOfRangeException(nameof(genre), genre, null),
      };
}
