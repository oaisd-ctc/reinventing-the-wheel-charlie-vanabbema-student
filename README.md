# Reinventing The Wheel
### Developed By: Charlie Van Abbema and Blair Ciolk
#

## ***Code Snippets, Uses and Descriptions***

## String Utilites
### ToUpper Method

The "ToUpper" method changes any lowercase character in a string into its uppercase counterpart.

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
*This method uses ASCII codes to swap out the letters for uppercase*


### "ToUpper" Method Implementation
#### To implement the "ToUpper" method, you must reference its class (StringUtils) and type the correct method (ToUpper) as shown below. Enter the parameter between the parenthesis.
``` Csharp
StringUtils.ToUpper(input)
```

### ***Images***
![some_image_here](some_filepath_here)
*Here's a super helpful caption*

### ***Admonition***
> :warning: **Warning:** Do not push the big red button.

> :memo: **Note:** Sunrises are beautiful.

> :bulb: **Tip:** Remember to appreciate the little things in life.