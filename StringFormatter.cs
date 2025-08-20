using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        /*
         * Improvements made:
         - Corrected typo error in method name ToCommaSeparatedList.
         - Removed redundancy by removing StringBuilder contructor line and the loop. Used string.Join which is inbuild .net method for string.
         - Using string.Join code is simplified and easy to read.
         - Added null or empty validation for items array and return an ArgumentException to caller with proper error message.
         - Instead of string.Format, Used lambda expression and string interpolation for better readerbility.
         - Used null coalescing operator for quote prameter to build string without quotes when its null. Used the same to check each item is null or not, if null, it will add blank "" instead of null in the string
         * */
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            if (items == null || items.Length == 0)
                throw new ArgumentException("Items array cannot be null or empty.", nameof(items));
            else
                return string.Join(",", items.Select(item => $"{quote ?? ""}{item ?? ""}{quote ?? ""}"));
                        
        }
    }
}
