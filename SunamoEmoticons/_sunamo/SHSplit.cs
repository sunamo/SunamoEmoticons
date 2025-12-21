namespace SunamoEmoticons._sunamo;

internal class SHSplit
{
    internal static string[] SplitByWhiteSpaces(string text)
    {
        return text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    }
}