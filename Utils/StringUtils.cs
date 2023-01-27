namespace MyUtilities
{


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

        public static string Length(string input)
        {

            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                count++;
            }
            // Console.WriteLine(count);
            return Convert.ToString(count);
        }

        public static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();

            string reversedString = String.Empty;

            int length, index;
            length = charArray.Length - 1;
            index = length;

            while (index > -1)
            {
                reversedString = reversedString + charArray[index];
                index--;
            }
            return reversedString;
        }

        // public static string CountVowels(string input)
        // {
        //     string[] vowels = {"a", "e", "i", "o", "u","y"};


        // }











    }

}