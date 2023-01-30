using Xunit;
using MyUtilities;

public class Tests
{

    [Fact]
    public void ToUpperTest()
    {
        string lowercase = "hello world";
        string desiredResult = "HELLO WORLD";

        Assert.Equal(desiredResult, StringUtils.ToUpper(lowercase));
    }


    [Fact]
    public void ToLowerTest()
    {
        string desiredResult = "hello world";
        string lowercase = "HELLO WORLD";

        Assert.Equal(desiredResult, StringUtils.ToLower(lowercase));
    }

    [Fact]
    public void LengthTest()
    {
        int desiredResult = 11;
        string uppercase = "HELLO WORLD";

        Assert.Equal(desiredResult, StringUtils.Length(uppercase));
    }

    [Fact]
    public void ReverseTest()
    {
        string desiredResult = "olleh";
        string lowercase = "hello";

        Assert.Equal(desiredResult, StringUtils.Reverse(lowercase));
    }

    [Fact]
    public void CountVowelsTest()
    {
        string example = "hEllo";
        int count = 2;

        Assert.Equal(count, StringUtils.CountVowels(example));
    }

    [Fact]
    public void CountConsonantsTest()
    {
        string example = "hElLo";
        int count = 3;
        Assert.Equal(count, StringUtils.CountConsonants(example));
    }
    [Fact]
    public void HasLetterTest()
    {
        string input = "hola";
        char letter = 'a';
        bool hasletter = true;
        Assert.Equal(hasletter, StringUtils.HasLetter(letter, input));
    }
    [Fact]
    public void VowelsToLowerTest()
    {
        string lowercase = "HELLO WORLD";
        string desiredResult = "HeLLo WoRLD";

        Assert.Equal(desiredResult, StringUtils.VowelsToLower(lowercase));
    }
    [Fact]
    public void VowelsToUpperTest()
    {
        string lowercase = "hello world";
        string desiredResult = "hEllO wOrld";

        Assert.Equal(desiredResult, StringUtils.VowelsToUpper(lowercase));
    }
    [Fact]
    public void ExtendTest()
    {
        string lowercase = "hello world";
        string desiredResult = "hheelllloo  wwoorrlldd";

        Assert.Equal(desiredResult, StringUtils.Extend(lowercase));
    }
    [Fact]
    public void ScrambleTest()
    {
        string input = "Precipitation";
        string desiredResult = "Pericipatitno";

        Assert.Equal(desiredResult, StringUtils.Scramble(input));
    }
}