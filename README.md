# Reinventing The Wheel
### Developed By: Charlie Van Abbema and Blair Ciolk

#  FAQ:
## *What is **Reinventing the Wheel?***
#### **Reinventing the Wheel** is an all-in-one utility tool for those who might need more methods for their projects.  
  
## *Why was this package made?*
#### The main goal of this project was to help other people with methods that they cannot figure out with pre-made methods that are easily integrated within your code. 

## ***Code Snippets, Uses and Descriptions***
> ## String Utilites
 ### ToUpper Method

The ToUpper method changes any lowercase character in a string into its uppercase counterpart.
##### Input: (String) Input
##### Output: (String)

``` Csharp
public static string ToUpper(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    output += (char)(input[i] - 'a' + 'A');
                }
                else
                    output += input[i];
            }
            return output;
        }
``` 
*This method uses ASCII codes to swap out the letters for uppercase.*


### ToUpper Method Implementation
#### To implement the ToUpper method, you must reference its class (StringUtils) and the correct method (ToUpper) as shown below. Enter an argument between the parenthesis.
``` Csharp
StringUtils.ToUpper(input)
```

### ToLower Method

The ToLower method allows the implementor to convert uppercase characters in a string into lowercase characters.
##### Input: (String) Input
##### Output: (String)
```Csharp
public static string ToLower(string input)
    {
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 'A' && input[i] <= 'Z')
            {
                output += (char)(input[i] - 'A' + 'a');
            }
            else
                output += input[i];
        }
        return output;
    }
```
*This method also uses ASCII codes.*

### ToLower Method Implementation

#### To implement the ToLower method, you must reference its class (StringUtils) and the correct method (ToLower) as shown below. Enter an argument between the paranthesis.
```Csharp
StringUtils.ToLower(input)
```

### Length Method
#### The length method allows the implementor to count how many characters are in a string.
##### Input: (String) Input
##### Output: (Int)
```Csharp
public static int Length(string input)
    {

        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            count++;
        }
        return count;
    }
```
#### I think this one has an error ngl
### Length Method Implementation

####  To implement the Length method, you must reference its class (StringUtils) and the correct method (Length) as shown below. Enter an argument between the paranthesis.
###### :bulb: Tip: Using the correct class is crucial for using the correct method, as some classes might share method names.
```Csharp
StringUtils.Length(input);
```

### Reverse Method
#### The Reverse method allows the implementor to reverse a given string.
##### Input: (String) Input
##### Output: (String)
```Csharp
public static string Reverse(string input)
    {
        string reverse = "";
        for (int i = input.Length - 1; i > -1; i--)
        {
            reverse += input[i];
        }
        return reverse;
    }
```
### Reverse Method Implementation
#### To implement the Reverse method, you must reference its class (StringUtils) and the correct method (Reverse) as shown below. Enter an argument between the parenthesis.
```Csharp
StringUtils.Reverse(input);
```

### CountVowels Method
#### The CountVowels method allows the implementor to count the vowels in a given string.
##### Input: (String) Input
##### Output: (Int)
```Csharp
public static int CountVowels(string input)
    {
        int total = 0;
        input = StringUtils.ToLower(input);
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
            {
                total++;
            }
        }
        return total;
    }
```
### CountVowels Method Implementation
#### To implement the CountVowels method, you must reference its class (StringUtils) and the correct method (CountVowels) as shown below. Enter an argument between the parenthesis.
```Csharp
StringUtils.CountVowels(input);
```

### CountConsonants Method
#### The CountConsonants method allows the implementor to count the consonants in a given string.
##### Input: (String) Input
##### Output: (Int)
```Csharp
public static int CountConsonants(string input)
    {
        int total = 0;
        input = StringUtils.ToLower(input);
        for (int i = 0; i < input.Length; i++)
        {
            if (!(input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u'))
            {
                total++;
            }

        }
        return total;
    }
```
### CountConsonants Method Implementation
#### To implement the CountConsonants method, you must reference its class (StringUtils) and the correct method (CountConsonants) as shown below. Enter an argument between the parenthesis.
```Csharp
StringUtils.CountConsonants(example);
```

### HasLetter Method
#### The HasLetter method allows the implementor to check a string for a certain letter.
##### Input: (Char) Letter, (String) Input
##### Output: (Bool)
```Csharp
public static bool HasLetter(char letter, string input)
    {
        input = StringUtils.ToLower(input);
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == letter)
            {
                return true;
            }
            else
            {
                continue;
            }
        }
        return false;
    }
```
### HasLetter Method Implementation
#### To implement the HasLetter method, you must reference its class (StringUtils) and the correct method (HasLetter) as shown below. Enter an argument between the parenthesis.
```Csharp
StringUtils.HasLetter(letter, input);
```

### VowelsToLower Method
#### The VowelsToLower method allows the implementor to convert uppercase vowels into lowercase vowels.
##### Input: (String) Input
##### Output: (String)
```Csharp
public static string VowelsToLower(string input)
    {
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
            {
                output += (char)(input[i] - 'A' + 'a');
            }
            else
                output += input[i];

        }
        return output;
    }
```
### VowelsToLower Method Implementation
#### To implement the VowelsToLower method, you must reference its class(StringUtils) and the correct method (VowelsToLower) as shown below. Enter an argument between the parenthesis.
```Csharp
StringUtils.VowelsToLower(input);
```

### VowelsToUpper
#### The VowelsToUpper method allows the implementor to convert lowercase vowels into uppercase vowels.
##### Input: (String) Input
##### Output: (String)
```Csharp
public static string VowelsToUpper(string input)
    {
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
            {
                output += (char)(input[i] - 'a' + 'A');
            }
            else
                output += input[i];
        }
        return output;
    }
```
### VowelsToUpper Method Implementation
#### To implement the VowelsToUpper method, you must reference its class (StringUtils) and the correct method (VowelsToUpper) as shown below. Enter an argument between the parenthesis.
```Csharp
StringUtils.VowelsToUpper(input);
```

### Extend Method
#### The Extend method allows the implementor to extend the string with duplicated letters.
##### Input: (String) Input
##### Output: (String)
```Csharp
public static string Extend(string input)
    {
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            output += input[i];
            output += input[i];
        }
        return output;
    }
```

### Extend Method Implementation
#### To implement the Extend method, you must reference its class (StringUtils) and the correct method (Extend) as shown below. Enter an argument between the parenthesis.
```Csharp
StringUtils.Extend(input);
```

### Scramble Method
#### The Scramble method allows the implementor to scramble the order of letters within a string.
##### Input: (String) Input
##### Output: (String)
```Csharp
public static string Scramble(string input)
    {
        // int count = 2;
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0 || i == input.Length)
            {
                output += input[i];
            }
            else if (i % 2 != 0)
            {
                output += input[i + 1];
            }
            else if (i % 2 == 0)
            {
                output += input[i - 1];
            }
        }
        return output;
    }
```
### Scramble Method Implementation
#### To implement the Scramble method, you must reference its class (StringUtils) and the correct method (Extend) as shown below. Enter an argument between the parenthesis.
```Csharp
StringUtils.Scramble(input);
```

> ## Math Utilities
### Power Method
#### The Power method allows the implementor to multiply a number x by itself y amount of times.
##### Input: (Int, Decimal, Double) x, (Int, Decimal, Double) y
##### Output: (Int, Decimal, Double)
```Csharp
public static int Power(int x, int y)
        {
            int z = x;
            for (int i = y; i > 1; i--)
            {
                z *= x;
            }
            return z;
        }
```
#### To implement the Power method, you must reference its class (MathUtils) and the correct method (Power) as shown below. Enter an argument between the parenthesis.
```Csharp
int x = 4;
int y = 3;

MathUtils.Power(x,y);
```
### SquareRoot Method
#### The SquareRoot method allows the implementor to square root a number.
##### Input: (Int, Double, Decimal) x
##### Output: (Int, Double, Decimal)
```Csharp
public static double SquareRoot(double x)
        {
            if (x < 2)
                return x;

            double y = x;
            double z = (y + (x / y)) / 2;

            while (MathUtils.AbsoluteValue(y - z) > 0)
            {
                y = z;
                z = (y + (x / y)) / 2;

            }
            return z;
        }
```
### SquareRoot Method Implementation
#### To implement the SquareRoot method, you must reference its class (MathUtils) and the correct method (SquareRoot) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.SquareRoot(x);
```

### AddNumbers Method
#### The AddNumbers method allows the implementor to add a number x and a number y to find and print the sum.
##### Input: (Int, Double, Decimal) x, (Int, Double, Decimal) y
##### Output: (Int, Double, Decimal)
```Csharp
 public static int AddNumbers(int x, int y)
        {
            int z = x + y;
            return z;
        }
```
### AddNumbers Method Implementation
#### To implement the AddNumbers method, you must reference its class (MathUtils) and the correct method (AddNumbers) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.AddNumbers(x, y);
```

### SubtractNum Method
#### The SubtractNum method allows the implementor to subtract a number x from a number y, returning the result.
##### Input: (Int, Double, Decimal) x, (Int, Double, Decimal) y
##### Output: (Int, Double, Decimal)
```Csharp
 public static int SubtractNum(int x, int y)
        {
            int z = x - y;
            return z;
        }
```
### SubtractNum Method Implementation
#### To implement the SubtractNum method, you must reference its class (MathUtils) and the correct method (SubtractNum) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.SubtractNum(x, y);
```

### DivideNums Method
#### The DivideNums method allows the implementor to divide a number x by a number y to find and print the quotient.
##### Input: (Int, Double, Decimal) x, (Int, Double, Decimal) y
##### Output: (Int, Double, Decimal)
```Csharp
public static int DivideNums(int x, int y)
        {
            int z = x / y;
            return z;
        }
```
### DivideNums Method Implementation
#### To implement the DivideNums method, you must reference its class (MathUtils) and the correct method (DivideNums) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.DivideNums(x, y);
```

### MultiplyNums Method
#### The MultiplyNums method allows the implementor to multiply a number x by a number y to find and print the product.
##### Input: (Int, Double, Decimal) x, (Int, Double, Decimal) y
##### Output: (Int, Double, Decimal)
```Csharp
public static double MultiplyNums(int x, int y)
        {
            int z = x * y;
            return z;
        }
```

### MultiplyNums Method Implementation
#### To implement the MultiplyNums method, you must reference its class (MathUtils) and the correct method (MultiplyNums) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.Multiply(x, y)
```

### FindMax Method
#### The FindMax method allows the implementor to find the largest value between a number x and a number y.
##### Input: (Int, Double, Decimal) x, (Int, Double, Decimal) y
##### Output: (Int, Double, Decimal)
```Csharp
public static int FindMax(int x, int y)
        {
            if (x > y)
            {
                int max = x;
                return max;
            }
            else
            {
                int max = y;
                return max;
            }
        }
```
### FindMax Method Implementation
#### To implement the FindMax method, you must reference its class (MathUtils) and the correct method (FindMax) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.FindMax(x, y);
```


### FindMin Method
#### The FindMin method allows the implementor to find the smallest value between a number x and a number y.
##### Input: (Int, Double, Decimal) x, (Int, Double, Decimal) y
##### Output: (Int, Double, Decimal)
```Csharp
public static int FindMin(int x, int y)
        {
            if (x > y)
            {
                int min = y;
                return min;
            }
            else
            {
                int min = x;
                return min;
            }
        }
```

### FindMin Method Implementation
#### To implement the FindMin method, you must reference its class (MathUtils) and the correct method (FindMin) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.FindMin(x, y);
```

### AbsoluteValue Method
#### The AbsoluteValue method allows the implementor to find the absolute value of a number x.
##### Input: (Int, Double, Decimal) x, (Int, Double, Decimal) y
##### Output: (Int, Double, Decimal)
```Csharp
public static int AbsoluteValue(int x)
        {
            if (x < 0)
            {
                x = x * -1;
                return x;
            }
            else
            {
                return x;
            }
        }
```

### AbsoluteValue Method Implementation
#### To implement the AbsoluteValue method, you must first reference its class (MathUtils) and the correct method (AbsoluteValue) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.AbsoluteValue(x);
```

### Sign Method
#### The Sign method allows the implementor to check whether a number is greater than, equal to, or less than zero, and returns a number corresponding.
##### Input: (Int, Double, Decimal) x,
##### Output (Int, Double, Decimal)
```Csharp
public static int Sign(int x)
        {

            if (x > 0)
            {
                int y = 1;
                return y;
            }
            else if (x < 0)
            {
                int y = -1;
                return y;
            }
            else
            {
                int y = 0;
                return y;
            }
        }
```

### Sign Method Implementation
#### To implement the Sign method, you must first reference its class (MathUtils) and the correct method (Sign) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.Sign(x);
```

### AreaOfRect Method
#### The AreaOfRect method allows the implementor to find the area of a rectangle using the length and the width.
##### Input: (Int, Double, Decimal) length, (Int, Double, Decimal) width
##### Output: (Int, Double, Decimal)
```Csharp
 public static int AreaOfRect(int length, int width)
        {
            int ans = length * width;
            return ans;
        }
```

### AreaOfRect Method Implementation
#### To implement the AreaOfRect method, you must first reference its class (MathUtils) and the correct method (Sign) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.AreaOfRect(length, width);
```

### AreaOfRhombus
#### The AreaOfRhombus method allows the implementor to find the area of a rhombus using the length and the width.
##### Input: (Int, Double, Decimal) x, (Int, Double, Decimal) y
##### Output: (Int, Double, Decimal)
```Csharp
public static int AreaOfRhombus(int x, int y)
        {
            int math = x * y;
            int answer = math / 2;
            return answer;
        }
```
### AreaOfRhombus Method Implementation
#### To implement the AreaOfRhombus method, you must first reference its class (MathUtils) and the correct method (Sign) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.AreaOfRhombus(x, y);
```

### SurfaceAreaOfCube Method
#### The SurfaceAreaOfCube method allows the implementor to find the surface area of a cube using the value of the edge.
##### Input: (Int, Double, Decimal) x
##### Output: (Int, Double, Decimal)
```Csharp
 public static int SurfaceAreaOfCube(int x)
        {
            int math = MathUtils.Power(x, 2);
            int answer = (int)MathUtils.MultiplyNums(math, 6);

            return answer;
        }
```
### SurfaceAreaOfCube Method Implementation
#### To implement the SurfaceAreaOfCube method, you must first reference its class (MathUtils) and the correct method (SurfaceAreaOfCube) as shown below. Enter an argument between the parenthesis.
```Csharp
MathUtils.SurfaceAreaOfCube(x);
```
> ## Array Utilities


### FindAverage Method
#### The FindAverage method allows the implementor to find the average value of the given array.
##### Input: (Int[], Double[], Decimal[]) x
##### Output: (Int, Double, Decimal)
```Csharp
public static int FindAverage(int[] x)
        {
            int length = 0;

            int result = 0;
            foreach (var y in x)
            {
                result += y;
                length = length++;
            }
            length = ArrayUtils.FindLength(x);
            result = result / length;


            return result;
        }
```
### FindAverage Method Implementation
#### To implement the FindAverage method, you must first reference its class (ArrayUtils) and the correct method (FindAverage) as shown below. Enter an argument between the parenthesis.
```Csharp
ArrayUtils.FindAverage(x[]);
```

### FindLength Method
#### The FindLength method allows the implementor to find the length of the given array.
##### Input: (Int[], Double[], Decimal[]) x
##### Output: (Int, Double, Decimal)
```Csharp
public static int FindLength(int[] x)
        {
            var length = 0;
            foreach (var y in x)
            {
                length++;
            }
            return length;
        }
```

### FindLength Method Implementation
#### To implement the FindLength method, you must first reference its class (ArrayUtils) and the correct method (FindLength) as shown below. Enter an argument between the parenthesis.
```Csharp
ArrayUtils.FindLength(x[]);
```

### FindMax Method
#### The FindMax method allows the implementor to find the max value in a given array.
##### Input: (Int[], Double[], Decimal[]) x
##### Output: (Int, Double, Decimal)
```Csharp
public static int FindMax(int[] x)
        {
            int max = 0;
            int min = 0;
            foreach (int y in x)
                if (y > max)
                    max = y;
                else
                    min = y;
            return max;
        }
```

### FindMax Method Implementation
#### To implement the FindMax method, you must first reference its class (ArrayUtils) and the correct method (FindLength) as shown below. Enter an argument between the parenthesis.
```Csharp
ArrayUtils.FindMax(x[]);
```

### FindMin Method
#### The FindMin method allows the implementor to find the minimum value in a given array.
##### Input: (Int[], Double[], Decimal[]) x
##### Output: (Int, Double, Decimal)
```Csharp
public static int FindMin(int[] x)
        {
            int[] testArray = { 3, 6, 4 };
            int i = 0;
            int small = 0;

            small = testArray[0];
            for (i = 1; i < ArrayUtils.FindLength(x); i++)
            {
                if (small > x[i])
                    small = x[i];
            }
            return small;
        }
```
### FindMin Method Implementation
#### To implement the FindMin method, you must first reference its class (ArrayUtils) and the correct method (FindMin) as shown below. Enter an argument between the parenthesis.
```Csharp
ArrayUtils.FindMin(x[]);
```

### FindSum Method
#### The FindSum method allows the implementor to find the sum of all values in a given array.
##### Input: (Int[], Double[], Decimal[]) x
##### Output: (Int, Double, Decimal)
```Csharp
public static int FindSum(int[] x)
        {

            int result = 0;
            foreach (var y in x)
            {
                result += y;
            }
            return result;
        }
```
### FindSum Method Implementation
#### To implement the FindSum method, you must first reference its class (ArrayUtils) and the correct method (FindSum) as shown below. Enter an argument between the parenthesis.
```Csharp
ArrayUtils.FindSum(x[]);
```

### FindProduct Method
#### The FindProduct method allows the implementor to find the product of all values in a given array.
##### Input: (Int[], Double[], Decimal[]) x
##### Output: (Int, Double, Decimal)
```Csharp
public static int FindProduct(int[] x)
        {

            int result = 1;
            foreach (var y in x)
            {
                result *= y;
            }
            return result;
        }
```
### FindProduct Method Implementation
#### To implement the FindProduct method, you must first reference its class (ArrayUtils) and the correct method (FindProduct) as shown below. Enter an argument between the parenthesis.`
```Csharp
ArrayUtils.FindProduct(x[]);
```
