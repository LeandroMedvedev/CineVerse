namespace CineVerse.API.Helpers;

using System.Globalization;

public static class Text
{
    public static string CapitalizeWords(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        var cultureInfo = CultureInfo.CurrentCulture;
        var textInfo = cultureInfo.TextInfo;

        return textInfo.ToTitleCase(input);
    }
}
