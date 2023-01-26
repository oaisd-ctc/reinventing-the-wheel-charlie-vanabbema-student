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
        string desiredResult = "11";
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
    public void PowerTest()
    {
        double desiredResult = 4;
        double input = 2f;

        Assert.Equal(desiredResult, MathUtils.Power(input, input));
    }

    // [Fact]
    // public void SqRtTest()
    // {
    //     double desiredResult = 8;
    //     double input = 64;

    //     Assert.Equal(desiredResult, MathUtils.SquareRoot(input));
    // }

    [Fact]
    public void AddNumbersTest()
    {

        double desiredResult = 8.5;
        double x = 4.4;
        double y = 4.1;

        Assert.Equal(desiredResult, MathUtils.AddNumbers(x, y));
    }

    [Fact]
    public void DivideNumsTest()
    {
        double desiredResult = 1.67;
        double x = 10;
        double y = 6;

        Assert.Equal(desiredResult, Math.Round(MathUtils.DivideNums(x, y),2));
    }

    [Fact]
    public void MultiplyNumsTest()
    {
        int desiredResult = 6;
        double x = 3;
        double y = 2;

        Assert.Equal(desiredResult, MathUtils.MultiplyNums(x,y));
    }

    [Fact]
    public void FindMaxTest()
    {
        double desiredResult = 8.15;
        double x = 3.549;
        double y = 8.15;

        Assert.Equal(desiredResult, MathUtils.FindMax(x,y));
    }

    [Fact]
    public void FindMinTest()
    {
        double desiredResult = 3;
        double x = 3;
        double y = 5;

        Assert.Equal(desiredResult, MathUtils.FindMin(x,y));
    }


}