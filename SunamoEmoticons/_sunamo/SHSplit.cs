namespace SunamoEmoticons._sunamo;

/// <summary>
/// Helper class for splitting strings.
/// </summary>
internal class SHSplit
{
    /// <summary>
    /// Splits text by whitespace characters (space, tab, newline, carriage return).
    /// </summary>
    /// <param name="text">The text to split.</param>
    /// <returns>Array of non-empty strings after splitting by whitespace.</returns>
    internal static string[] SplitByWhiteSpaces(string text)
    {
        return text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    }
}
