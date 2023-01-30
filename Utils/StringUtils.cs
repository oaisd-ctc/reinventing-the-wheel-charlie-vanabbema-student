namespace MyUtilities;

public static class StringUtils
{
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

    public static int Length(string input)
    {

        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            count++;
        }
        return count;
    }

    public static string Reverse(string input)
    {
        string reverse = "";
        for (int i = input.Length - 1; i > -1; i--)
        {
            reverse += input[i];
        }
        return reverse;
    }

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

    public static string VowelsToUpper(string input)
    {
        string output = "";
        // input = StringUtils.ToLower(input);
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
    public static string Scramble(string input)
    {
        // int count = 2;
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            if(i==0||i==input.Length)
            {
                output += input[i];
            }
            else if (i % 2 != 0)
            {
                output += input[i + 1];
            }
            else if (i % 2 == 0)
            {
                output += input[i-1];
            }
        }
        return output;
    }
}