using Xunit;
using MyUtilities;

public class Tests
{

    // [Fact]
    // public void ToUpperTest()
    // {
    //     string lowercase = "hello world";
    //     string desiredResult = "HELLO WORLD";

    //     Assert.Equal(desiredResult, StringUtils.ToUpper(lowercase));
    // }


    // [Fact]
    // public void ToLowerTest()
    // {
    //     string desiredResult = "hello world";
    //     string lowercase = "HELLO WORLD";

    //     Assert.Equal(desiredResult, StringUtils.ToLower(lowercase));
    // }

    // [Fact]
    // public void LengthTest()
    // {
    //     string desiredResult = "11";
    //     string uppercase = "HELLO WORLD";

    //     Assert.Equal(desiredResult, StringUtils.Length(uppercase));
    // }

    [Fact]
    public void ReverseTest()
    {
        string desiredResult = "olleh";
        string lowercase = "hello";

        Assert.Equal(desiredResult, StringUtils.Reverse(lowercase));
    }
}