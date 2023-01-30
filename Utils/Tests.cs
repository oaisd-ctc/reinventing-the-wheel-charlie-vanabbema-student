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
    [Fact]
    public void AbsoluteValueTest()
    {
        int desiredResult = 4;
        int x = -4;

        Assert.Equal(desiredResult, MathUtils.AbsoluteValue(x));
    }

    [Fact]
    public void SquareRootTest()
    {
        int desiredResult = 8;
        int x = 64;

        Assert.Equal(desiredResult, MathUtils.SquareRoot(x));
    }

    [Fact]
    public void SignTest()
    {
        int desiredResult = 0;
        int x = 0;

        Assert.Equal(desiredResult, MathUtils.Sign(x));
    }

    [Fact]
    public void AreaOfRectTest()
    {
        int desiredResult = 12;
        int x = 4;
        int y = 3;


        Assert.Equal(desiredResult, MathUtils.AreaOfRect(x,y));
    }

    [Fact]
    public void AreaOfRhombusTest()
    {
        double desiredResult = 21.45;
        double x = 5.5;
        double y = 7.8;

        Assert.Equal(desiredResult, MathUtils.AreaOfRhombus(x,y));
    }

    [Fact]
    public void SurfaceAreaOfCubeTest()
    {
        double desiredResult = 337.5;
        double x = 7.5;

        Assert.Equal(desiredResult, MathUtils.SurfaceAreaOfCube(x));
    }




}