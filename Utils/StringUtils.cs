namespace MyUtilities;

public static class StringUtils
{
    /// <summary>
    /// Makes a string all into Uppercase letters.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// The new string in all Uppercase.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Makes a string all into Lowercase letters.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// The new string in all Lowercase.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>

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
    /// <summary>
    /// Finds how many characters are in a string.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// An int of the string length.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>

    public static int Length(string input)
    {

        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            count++;
        }
        return count;
    }
    /// <summary>
    /// Makes a new string the reverse of another.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// The new string in reverse.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>

    public static string Reverse(string input)
    {
        string reverse = "";
        for (int i = input.Length - 1; i > -1; i--)
        {
            reverse += input[i];
        }
        return reverse;
    }
    /// <summary>
    /// Counts how many vowels are in a string.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// Int amount of vowels.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Counts how many consonants are in a string.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// Int amount of consonants.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>

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
    /// <summary>
    /// Checks if a string contains a specific character
    /// </summary>
    /// <param name="letter">The character.</param>
    /// <param name="input">The string.</param>
    /// <returns>
    /// True if string contains character, otherwise false.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>  

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
    /// <summary>
    /// Makes the vowels in a string all Lowercase.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// The new string with Lowercase vowels.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Makes the vowels in a string all Uppercase.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// The new string with Uppercase vowels.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Makes the string longer with duplicated letters.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// The new extended string.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
    /// <summary>
    /// Scrambles the order of letters in the word.
    /// </summary>
    /// <param name="input">The string.</param>
    /// <returns>
    /// The new scrambled string.
    /// </returns>
    /// <remarks>
    /// For use with local systems
    /// </remarks>
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
}