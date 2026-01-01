namespace SunamoEmoticons.Tests;

using Microsoft.Extensions.Logging.Abstractions;

/// <summary>
/// Unit tests for SunamoEmoticons library.
/// </summary>
public class UnitTest1
{
    /// <summary>
    /// Tests that GetAllEmotions returns a non-empty list of emoticons.
    /// </summary>
    [Fact]
    public void GetAllEmotions_ReturnsNonEmptyList()
    {
        // Arrange
        var logger = NullLogger.Instance;

        // Act
        var result = EmoticonsHelper.GetAllEmotions(logger);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
    }

    /// <summary>
    /// Tests that GetAllEmotions returns common emoticons like :) and :(.
    /// </summary>
    [Fact]
    public void GetAllEmotions_ContainsCommonEmoticons()
    {
        // Arrange
        var logger = NullLogger.Instance;

        // Act
        var result = EmoticonsHelper.GetAllEmotions(logger);

        // Assert
        Assert.Contains(":)", result);
        Assert.Contains(":(", result);
        Assert.Contains(":D", result);
        Assert.Contains(";)", result);
    }

    /// <summary>
    /// Tests that GetAllEmotions returns multiple emoticons (at least 50).
    /// </summary>
    [Fact]
    public void GetAllEmotions_ReturnsMultipleEmoticons()
    {
        // Arrange
        var logger = NullLogger.Instance;

        // Act
        var result = EmoticonsHelper.GetAllEmotions(logger);

        // Assert
        Assert.True(result.Count >= 50, $"Expected at least 50 emoticons, but got {result.Count}");
    }
}
