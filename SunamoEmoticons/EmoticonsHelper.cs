namespace SunamoEmoticons;

public class EmoticonsHelper
{
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
