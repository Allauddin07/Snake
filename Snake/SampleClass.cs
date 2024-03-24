using System;
using System.Text;
/* 
 * Have the function SnakeCase(str) take the str parameter being passed 
 * and return it in proper snake case format where each word is lowercased 
 * and separated from adjacent words via an underscore. The string will 
 * only contain letters and some combination of delimiter punctuation 
 * characters separating each word.
 * 
 * For example: if str is "BOB loves-coding" then your program should 
 * return the string bob_loves_coding.
 * 
 * Examples: 
 *   Input:  BOB loves-coding
 *   Output: bob_loves_coding
 *   
 *   Input:  I like cats&dogs
 *   Output: i_like_cats_dogs
 *   
 *   Input:  a b c d-e-f%g
 *   Output: a_b_d_d_e_f_g
 * 
 */

public class SampleClass
{
    public static string SnakeCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return "";

        StringBuilder snakeCaseBuilder = new StringBuilder();

        bool previousWasLetter = false;

        foreach (char c in str)
        {
            if (char.IsLetter(c))
            {
                if (previousWasLetter)
                {
                    snakeCaseBuilder.Append(char.ToLower(c));
                }
                else
                {
                    snakeCaseBuilder.Append('_');
                    snakeCaseBuilder.Append(char.ToLower(c));
                    previousWasLetter = true;
                }
            }
            else
            {
                previousWasLetter = false;
            }
        }

        return snakeCaseBuilder.ToString().Trim('_');
    }


    static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(SnakeCase("BOB loves-coding")); // Output: bob_loves_coding
        Console.WriteLine(SnakeCase("I like cats&dogs")); // Output: i_like_cats_dogs
        Console.WriteLine(SnakeCase("a b c d-e-f%g"));    // Output: a_b_c_d_e_f_g
    }
}
