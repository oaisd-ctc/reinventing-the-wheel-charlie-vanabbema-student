# Reinventing The Wheel
### Developed By: Charlie Van Abbema and Blair Ciolk

## ***Code Snippets, Uses and Descriptions***
> ## String Utilites
 ### ToUpper Method

The ToUpper method changes any lowercase character in a string into its uppercase counterpart.

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
#### To implement the ToUpper method, you must reference its class (StringUtils) and the correct method (ToUpper) as shown below. Enter the argument between the parenthesis.
``` Csharp
StringUtils.ToUpper(input)
```

### ToLower Method

The ToLower method allows the implementor to convert uppercase characters in a string into lowercase characters.
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

#### To implement the ToLower method, you must reference its class (StringUtils) and the correct method (ToLower) as shown below. Enter the argument between the paranthesis.
```Csharp
StringUtils.ToLower(input)
```

### Length Method
#### The length method allows the implementor to count how many characters are in a string.
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

####  To implement the Length method, you must reference its class (StringUtils) and the correct method (Length) as shown below. Enter the argument between the paranthesis.
###### :bulb: Tip: Using the correct class is crucial for using the correct method, as some classes might share method names.
```Csharp
StringUtils.Length(input);
```

### Reverse Method
#### The Reverse method allows the implementor to reverse a given string.
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
#### To implement the Reverse method, you must reference its class (StringUtils) and the correct method (Reverse) as shown below. Enter the argument between the parenthesis.
```Csharp
StringUtils.Reverse(input);
```

### CountVowels Method
#### The CountVowels method allows the implementor to count the vowels in a given string.
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
### CountConsonants Method
#### The CountConsonants method allows the implementor to count the consonants in a given string.
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
### CountConsonants


#  FAQ:
## *What is **Reinventing the Wheel?***
#### **Reinventing the Wheel** is an all-in-one utility tool for those who might need more methods for their projects.  
  
## *Why was this package made?*
#### The main goal of this project was to help other people with methods that they cannot figure out with pre-made methods that are easily integrated within your code. 

### ***Images***
![some_image_here](some_filepath_here)
*Here's a super helpful caption*

### ***Admonition***
> :warning: **Warning:** Do not push the big red button.

> :memo: **Note:** Sunrises are beautiful.

> :bulb: **Tip:** Remember to appreciate the little things in life.