namespace SunamoEmoticons;

/// <summary>
/// Helper class for working with emoticons.
/// </summary>
public class EmoticonsHelper
{
    /// <summary>
    /// Retrieves all emoticon strings from all fields in the Emoticons class.
    /// </summary>
    /// <param name="logger">Logger instance for logging debug information about null values.</param>
    /// <returns>List of all individual emoticon strings extracted from all emoticon fields.</returns>
    public static List<string> GetAllEmotions(ILogger logger)
    {
        var emoticons = new Emoticons();
        var fields = emoticons.GetType().GetFields();
        var result = new List<string>();
        foreach (var field in fields)
        {
            var value = field.GetValue(emoticons);
            if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString != null)
                {
                    result.AddRange(SHSplit.SplitByWhiteSpaces(valueAsString));
                }
                else
                {
                    logger.LogDebug(message: $"{field.Name}.ToString() in Emoticons was null");
                }
            }
            else
            {
                logger.LogDebug(message: $"{field.Name} in Emoticons was null");
            }
        }
        return result;
    }
}