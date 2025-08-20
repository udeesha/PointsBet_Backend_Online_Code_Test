// See https://aka.ms/new-console-template for more information


using PointsBet_Backend_Online_Code_Test;

//Testing the method. TODO: Need to create Unit tests for this. Not done as not instructed to do. 

//Test the array with valid quote
string formattedText = StringFormatter.ToCommaSeparatedList(new string[] { "toyota", "honda", "BMW" }, "\"");

Console.WriteLine($"Output: {formattedText}");

//Test with null quote
formattedText = StringFormatter.ToCommaSeparatedList(new string[] { "toyota", "honda", "BMW" }, null);

Console.WriteLine($"Output: {formattedText}");

//Test with null array
try {
    formattedText = StringFormatter.ToCommaSeparatedList(null, "\"");
}
catch( Exception ex) {
    Console.WriteLine($"Error: {ex.Message}");
}

//Test with empty array
try
{
    formattedText = StringFormatter.ToCommaSeparatedList(new string[] { }, "\"");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

