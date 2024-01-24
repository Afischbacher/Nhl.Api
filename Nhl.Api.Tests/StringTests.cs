using Nhl.Api.Models.Enumerations.Player;

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
}
