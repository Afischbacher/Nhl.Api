using Nhl.Api.Common.Extensions;

namespace Nhl.Api.Tests;

[TestClass]
public class StringTests
{

    [TestMethod]
    [DataRow("ŠĐĆŽćžšđ", "SDCZczsd")]
    [DataRow("àndre", "andre")]
    [DataRow("Héllo", "Hello")]
    [DataRow("Café", "Cafe")]
    [DataRow("Nöël", "Noel")]
    [DataRow("âpple", "apple")]
    [DataRow("böök", "book")]
    [DataRow("mønitor", "monitor")]
    [DataRow("éléphant", "elephant")]
    [DataRow("wôrld", "world")]
    public void ReplaceNonAsciiWithAscii_Returns_Correct_Ascii_String(string input, string expected)
    {
        var actual = PlayerEnumFileGeneratorHelper.ReplaceNonAsciiWithAscii(input);

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [DataRow("ŠĐĆŽćžšđ", "SDCZczsd")]
    [DataRow("àndre", "andre")]
    [DataRow("Héllo", "Hello")]
    [DataRow("Café", "Cafe")]
    [DataRow("Nöël", "Noel")]
    [DataRow("âpple", "apple")]
    [DataRow("böök", "book")]
    [DataRow("mønitor", "monitor")]
    [DataRow("éléphant", "elephant")]
    [DataRow("wôrld", "world")]
    public void ReplaceNonAsciiWithAscii_Returns_Correct_Ascii_String_Extension(string input, string expected)
    {
        Assert.AreEqual(input.ReplaceNonAsciiWithAscii(), expected);
    }

    [TestMethod]
    [DataRow("ÀÁÂÃÄÅ", "AAAAAA")]
    [DataRow("Æ", "AE")]
    [DataRow("ÇĆ", "CC")]
    [DataRow("ÈÉÊË", "EEEE")]
    [DataRow("ÌÍÎÏ", "IIII")]
    [DataRow("ÐĐ", "DD")]
    [DataRow("Ñ", "N")]
    [DataRow("ÒÓÔÕÖ", "OOOOO")]
    [DataRow("Ø", "O")]
    [DataRow("ÙÚÛÜ", "UUUU")]
    [DataRow("Š", "S")]
    [DataRow("ÝŸ", "YY")]
    [DataRow("Ž", "Z")]
    [DataRow("àáâãä", "aaaaa")]
    [DataRow("å", "a")]
    [DataRow("æ", "ae")]
    [DataRow("çć", "cc")]
    [DataRow("đ", "d")]
    [DataRow("èéêë", "eeee")]
    [DataRow("ìíîï", "iiii")]
    [DataRow("ð", "d")]
    [DataRow("ñ", "n")]
    [DataRow("òóôõö", "ooooo")]
    [DataRow("ø", "o")]
    [DataRow("ùúûü", "uuuu")]
    [DataRow("š", "s")]
    [DataRow("ýÿ", "yy")]
    [DataRow("ž", "z")]
    public void ReplaceNonAsciiWithAscii_Test(string input, string expected)
    {
        // Arrange
        // No need for arrange as we have input and expected values

        // Act
        var result = input.ReplaceNonAsciiWithAscii();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ReplaceNonAsciiWithAscii_WithEmptyString_Test()
    {
        // Arrange
        var input = "";
        var expected = "";

        // Act
        string result = input.ReplaceNonAsciiWithAscii();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ReplaceNonAsciiWithAscii_WithOnlyAsciiCharacters_Test()
    {
        // Arrange
        var input = "HelloWorld";
        var expected = "HelloWorld";

        // Act
        string result = input.ReplaceNonAsciiWithAscii();

        // Assert
        Assert.AreEqual(expected, result);
    }
}
